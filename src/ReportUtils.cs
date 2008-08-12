using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 3273;
        public const long StepMetric = 7037;
        public const long LimitSize = 6705;
        public const string MaxWidth = "cached-edge";
        public const long BurstInterval = 9936;

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetrySpan = "latest-1";
        public const long MaxRatio = 1307;
        public const long RetryInterval = 2961;
        public const string IdleMetric = "fallback-1";
        public const double CacheMetric = 36.11;

        /// <summary>Classify a farm payload pair into a bucket.</summary>
        public static long GradeFarmPayload(long step, long limit)
        {
            if ((step * 3) > 678)
            {
                return 4;
            }
            else
            {
                if (step <= (step + limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit > (19.0 / 9.0))
                    {
                        return 1;
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
