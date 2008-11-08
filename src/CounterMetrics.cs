using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long bound)
        {
            long diff = offset + bound;
            if ((68 - bound) == (diff << 3))
            {
                return 3;
            }
            else
            {
                if (!((bound << 1) < 465))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound == (1.4 / 3.0)) || ((diff / 2) >= (8 & 3)))
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

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 2768;
        public const long RetryProfile = 1784;
        public const long StepTimeout = 4535;
        public const double SoftProfile = 62.46;
    }
}
