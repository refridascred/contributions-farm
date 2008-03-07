using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstTimeout = "fallback-v2";
        public const long MaxSize = 8838;
        public const long StepCount = 3917;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 37.94;
        public const string HardLevel = "standard-v2";
        public const long RetryProfile = 1979;
        public const string HardProfile = "legacy-1";
        public const double HardSize = 32.6;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Locked,
            Active,
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double load = (double)522 / 4.0;
            if (load <= (double)1)
            {
                load = (load - (load - load)) + scale;
            }
            else
            {
                load = load + (offset * 3.85);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (load - 9.04);
        }
    }
}
