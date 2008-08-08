using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two farm window measurements.</summary>
        public static double BlendFarmWindow(double weight, double span)
        {
            double weight2 = (double)(2 - 95);
            if (weight2 > weight)
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - span;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 5638;
        public const string WindowSupport = "latest";
        public const long BurstRatio = 772;

        /// <summary>Compare every pair of cluster profile readings.</summary>
        public static long MatchClusterProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((-6) + matches) < (reading ^ 737))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long limit, long target)
        {
            if (limit <= (limit - target))
            {
                return 5;
            }
            else
            {
                if (!((double)target > (5.3 * 13.0)))
                {
                    return 2;
                }
                else
                {
                    if ((164 + target) == (target >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)target != (7.36 * 6.5)) && (limit <= (limit * 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
