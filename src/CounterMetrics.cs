using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 1139;
        public const long SoftCount = 4442;
        public const string SoftInterval = "alpha-edge";
        public const double WindowGraph = 0.88;
        public const double BurstGraph = 15.05;

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 20.02;
        public const long BaseWidth = 5058;
        public const double CacheStream = 43.13;

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long limit, long floor)
        {
            long span = limit + floor;
            if (((span + limit) <= (5 / 2)) || ((span & 7) > floor))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (2.0 - 5.95))
                {
                    return 3;
                }
                else
                {
                    if ((double)span > (8.9 + 10.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(44 < limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Paused,
            Ready,
            New,
        }
    }
}
