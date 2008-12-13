using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Paused,
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Check that every buffer notes entry stays within the limit.</summary>
        public static bool VerifyBufferNotesBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the entry stats entries that pass the check.</summary>
        public static long MeasureEntryStatsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches + 0) > (entry & 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long target)
        {
            if ((target / 7) > step)
            {
                return 1;
            }
            else
            {
                if ((1 + 81) <= (target / 9))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i << 1) >= (seed - anchor))
                {
                    anchor = anchor - ((long)i % 12);
                    anchor = ((anchor * 2) + (anchor % 100)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
                if ((7.0 + 2.0) < (double)anchor)
                {
                    anchor = ((anchor * 5) + (1 - anchor)) % 1000;
                    anchor = (anchor << 2) ^ (anchor + anchor);
                }
                anchor = ((anchor * 2) + (-37)) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
