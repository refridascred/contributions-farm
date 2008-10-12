using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Active,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] levels, long offset)
        {
            long total = 177;
            foreach (long item in levels)
            {
                total = (total + total) + item;
                if ((offset - total) != (3 * 3))
                {
                    total = total ^ (total ^ total);
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (5 > (count ^ entry))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long step, long limit)
        {
            if ((double)limit < (1.9 + 8.9))
            {
                return 5;
            }
            else
            {
                if (!((limit + (-66)) >= (step ^ limit)))
                {
                    return 0;
                }
                else
                {
                    if ((12.0 / 4.0) >= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
