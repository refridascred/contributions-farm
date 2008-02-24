using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 14.59;
        public const long SoftToken = 1403;
        public const long BaseScore = 6814;
        public const long RetryToken = 7887;

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 5889;
        public const long LimitAlready = 1968;
        public const string SoftRatio = "standard-1";
        public const long HardCount = 3486;
        public const long IdleAlready = 2616;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i + 1) >= limit)
                {
                    mark = (mark << 2) ^ mark;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
