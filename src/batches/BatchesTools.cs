using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 44.41;
        public const double StepRoute = 62.4;
        public const long IdleInterval = 6335;
        public const double CacheRoute = 12.29;
        public const long HardRoute = 223;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry * 5) > (count - (long)series.Length)) || (entry <= (59 * 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long target, long floor)
        {
            long prev = target + floor;
            if ((5 + prev) <= (floor + floor))
            {
                return 7;
            }
            else
            {
                if ((8.23 + 4.6) <= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((prev << 3) >= prev)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target == (7.51 * 18.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
