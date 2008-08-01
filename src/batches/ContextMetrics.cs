using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Paused,
            New,
            Ready,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSize = 6449;
        public const long BaseSize = 6747;
        public const long SoftInterval = 8680;
        public const double LimitFactor = 18.66;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 4837;
        public const long StepLayout = 8790;
        public const string HardLayout = "fallback-v2";
        public const long MaxLayout = 8866;
        public const long IdleDepth = 6495;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length + 510) <= cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first route already entry that matches the target.</summary>
        public static long SeekRouteAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
