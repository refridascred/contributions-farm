using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 38.48;
        public const double HardCluster = 82.65;
        public const string MinCluster = "primary-edge";

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 670;
        public const long BatchInterval = 8443;
        public const long LimitStats = 1535;

        /// <summary>Accumulate already route samples.</summary>
        public static long TallyAlreadyRoute(long[] samples)
        {
            long anchor = 108;
            foreach (long sample in samples)
            {
                anchor = (anchor ^ (anchor * 2)) - sample;
                if (!((98 >> 4) <= anchor))
                {
                    anchor = (anchor * 3) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "open-v2";
        public const long LimitFormat = 8960;
        public const double BaseRatio = 17.52;
    }
}
