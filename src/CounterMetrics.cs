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

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Weight { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }
    }
}
