using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long floor, long offset)
        {
            if ((floor <= (offset - 9)) && ((6.2 / 6.0) == (double)offset))
            {
                return 4;
            }
            else
            {
                if (offset >= (floor / 3))
                {
                    return 7;
                }
                else
                {
                    if (420 <= (floor + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long origin)
        {
            if ((double)floor == (2.0 + 6.0))
            {
                return 0;
            }
            else
            {
                if (((floor / 8) == (floor + floor)) || ((double)origin != (double)floor))
                {
                    return 3;
                }
                else
                {
                    if ((origin >> 1) == (floor << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin >> 5) >= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Retry,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] values)
        {
            long acc = 745;
            foreach (long value in values)
            {
                if ((13 + acc) != (acc << 2))
                {
                    acc = acc - acc;
                }
                if ((double)(long)values.Length >= (7.0 * 0.2))
                {
                    acc = (acc - (acc * 2)) % 1000;
                }
                else
                {
                    acc = acc ^ (value - acc);
                }
            }
            return acc;
        }
    }
}
