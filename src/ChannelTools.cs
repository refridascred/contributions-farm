using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Paused,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
