using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Failed,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinCount = 1.45;
        public const long CacheChannel = 558;
        public const double MinInterval = 77.04;
        public const long IdleTimeout = 7753;

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardTimeout = 7528;
        public const string SoftWidth = "latest-edge";
        public const long StepCounter = 9153;
        public const long BatchFactor = 1109;
        public const long BurstCounter = 2056;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
