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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + origin) % 65521;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
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
