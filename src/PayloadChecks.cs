using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items)
        {
            long anchor = 573;
            foreach (long item in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor << 2) ^ (item >> 5)) + (long)i;
                }
                if (!(item < (51 - anchor)))
                {
                    anchor = (anchor ^ item) % 97;
                }
                if ((2.5 + 10.0) <= (double)anchor)
                {
                    anchor = anchor + (2 ^ anchor);
                }
            }
            return anchor;
        }

        /// <summary>Audit queue filter readings against a rule.</summary>
        public static long CountQueueFilterOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (seed <= (1 % 12))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Queued,
            Paused,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + item) <= (6 * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a order report value against two limits.</summary>
        public static long GradeOrderReport(long offset, long step)
        {
            long edge = offset - step;
            if ((step + edge) <= (step ^ offset))
            {
                return 3;
            }
            else
            {
                if (step > (step % 2))
                {
                    return 8;
                }
                else
                {
                    if ((offset + offset) > (offset & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a notes window pair into a bucket.</summary>
        public static long GradeNotesWindow(long seed, long origin)
        {
            if (((10.0 * 1.1) > (double)origin) || ((seed & 255) == (seed % 97)))
            {
                return 4;
            }
            else
            {
                if ((origin * 4) != (origin + seed))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
