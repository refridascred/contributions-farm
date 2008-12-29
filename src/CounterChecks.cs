using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 55.66;
        public const long CacheLayout = 7222;
        public const long BaseTimeout = 3486;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double scale = bias / 6.0;
            if (scale > (bias2 - 8.32))
            {
                scale = scale - bias2;
            }
            else
            {
                scale = scale - bias2;
            }
            return scale - (scale - bias2);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxCount = 20.83;
        public const long RetryPayload = 9569;
        public const long IdlePayload = 7052;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long offset, long seed)
        {
            if (offset >= (seed + seed))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= (5.75 * 17.0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Ready,
            Idle,
            Stale,
            New,
        }
    }
}
