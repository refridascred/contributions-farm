using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a metrics already value against two limits.</summary>
        public static long SortMetricsAlready(long bound, long seed)
        {
            long cur = bound + seed;
            if ((5.67 + 12.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound - cur) < (seed << 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound == (0.3 * 2.8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (5.56 - 4.7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long seed, long limit)
        {
            long span = seed + limit;
            if ((span % 16) < (seed - 7))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) <= (span >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ span) > (15 & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)span > (3.49 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
