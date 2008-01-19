using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryScore = 35.23;
        public const long MaxChecks = 8778;
        public const long WindowChecks = 9840;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell <= hits) || ((cell & 31) > (hits % 97)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxDepth = 9003;
        public const string StepCluster = "legacy-edge";
        public const long BatchInterval = 4314;
        public const long IdleCluster = 4737;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = total + (step << 2);
                if (total <= (step & 255))
                {
                    total = total + total;
                }
                total = (total * 4) + (long)i;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a batch route value against two limits.</summary>
        public static long BucketBatchRoute(long bound, long target)
        {
            if ((bound + target) == (target - 31))
            {
                return 8;
            }
            else
            {
                if ((double)target < (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound - target) < ((-41) - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
