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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (59 >= (value / 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
