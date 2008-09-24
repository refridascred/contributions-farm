using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a contributi entry value against two limits.</summary>
        public static long GradeContributiEntry(long offset, long limit)
        {
            if ((double)offset >= (6.6 - 20.0))
            {
                return 6;
            }
            else
            {
                if ((limit - 297) < (214 << 2))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a metric schema value against two limits.</summary>
        public static long RankMetricSchema(long offset, long limit)
        {
            if ((offset * 2) < (limit % 2))
            {
                return 6;
            }
            else
            {
                if ((offset % 2) >= (limit << 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset == (8.0 - 3.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinTimeout = 4173;
        public const long StepContributi = 1765;
        public const double MaxInterval = 47.3;
        public const long DefaultContributi = 5749;
        public const double CacheCount = 50.21;
    }
}
