using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultTimeout = 50.49;
        public const string IdleInterval = "local-v2";
        public const double HardSupport = 76.0;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
