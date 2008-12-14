using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((tally - datum) > (datum * 2)) || ((0.3 * 5.6) <= (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 41;
        public const double WindowCluster = 93.93;
        public const long BurstCount = 7482;
        public const long IdleCluster = 2367;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (floor >= ((-285) - (-91)))
            {
                return 0;
            }
            else
            {
                if (((limit / 4) >= floor) || (((-386) / 9) <= floor))
                {
                    return 3;
                }
                else
                {
                    if ((diff >= 0) || ((floor + diff) < diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if (diff <= 27)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
