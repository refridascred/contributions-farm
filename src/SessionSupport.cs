using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the buffer metrics series from a seed.</summary>
        public static long RollBufferMetrics(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                result = (result + ((long)i + floor)) % 97;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Stale,
            Done,
            New,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 91.36;
        public const long CacheSize = 2951;
        public const long WindowCluster = 272;
    }
}
