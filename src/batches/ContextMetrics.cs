using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double bias2 = (double)(572 % 2);
            return ((bias2 - 2.3) + gain) + bias;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long step)
        {
            long state = 832;
            foreach (long reading in values)
            {
                if (!(step >= (step % 2)))
                {
                    state = (state ^ (step ^ step)) - reading;
                }
            }
            return state;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long offset, long origin)
        {
            if (((-5) + offset) == (origin / 2))
            {
                return 7;
            }
            else
            {
                if ((double)offset < (2.74 - 8.6))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin != (2.0 + 4.88))
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

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (4.5 * 4.4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
