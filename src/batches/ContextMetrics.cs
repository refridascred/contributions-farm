using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally > (6.0 - 0.2))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long bound2)
        {
            long cur = bound - bound2;
            if (16.0 <= (double)bound2)
            {
                return 1;
            }
            else
            {
                if ((bound2 ^ bound2) > 8)
                {
                    return 8;
                }
                else
                {
                    if (!((bound2 - cur) >= 344))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count <= reading) && (13.0 < (double)count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long mark = 264;
            foreach (long cell in levels)
            {
                mark = mark ^ (cell * 4);
                mark = mark ^ (cell % 10);
            }
            if (mark < 103)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }
    }
}
