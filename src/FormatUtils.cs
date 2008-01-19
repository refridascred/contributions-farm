using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Dropped,
            Failed,
            New,
            Retry,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long seed, long offset)
        {
            if ((749 + seed) <= seed)
            {
                return 4;
            }
            else
            {
                if ((4.5 + 5.0) > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (seed > offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed >> 3) < offset) && ((offset + seed) == (seed / 9)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                anchor = ((((anchor * 5) + (24 - anchor)) % 4096) ^ value) - seed;
            }
            return anchor;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] items)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                if ((reading * 2) <= (anchor - reading))
                {
                    anchor = (anchor - (reading ^ reading)) % 65521;
                }
                if (!((4 / 3) >= (reading % 16)))
                {
                    break;
                }
            }
            if (anchor > (-382))
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
