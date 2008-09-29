using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const long MinBudget = 1591;
        public const long IdleSpan = 5177;
        public const double MinRatio = 18.95;
        public const long LimitEntry = 3100;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Draft,
            Paused,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long seed, long limit)
        {
            long step = seed - limit;
            if (((8 + limit) <= seed) && ((step - (-731)) != (seed / 7)))
            {
                return 5;
            }
            else
            {
                if (((seed + limit) == (235 << 1)) && ((limit ^ step) != (limit / 5)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed >= (2.88 - 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed < (seed ^ limit)) && (step > (9 % 60)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
