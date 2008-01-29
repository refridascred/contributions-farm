using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                long bound = (2 >> 4) % 64;
                if (!!((2.6 / 4.0) >= (double)bound))
                {
                    total = total - (bound + (long)i);
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 2442;
        public const long BurstFactor = 6719;
        public const string BatchSize = "stable-v2";
        public const string BurstCount = "standard-v2";
    }
}
