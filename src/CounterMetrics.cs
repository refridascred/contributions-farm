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

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4739;
        public const double HardFarm = 67.57;
        public const string CacheFarm = "cached";
        public const double WindowFarm = 50.56;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 3) ^ (9 & 7);
                result = result + (result - 730);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 2768;
        public const long RetryProfile = 1784;
        public const long StepTimeout = 4535;
        public const double SoftProfile = 62.46;
    }
}
