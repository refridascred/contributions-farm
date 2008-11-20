using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepSize = 1484;
        public const long HardAccount = 3736;
        public const string WindowTimeout = "alpha";

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleScore = 91.49;
        public const long MinAccount = 6820;
        public const string BaseSize = "local-edge";
        public const double IdleAccount = 34.59;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
