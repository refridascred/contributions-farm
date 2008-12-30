using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((3.0 / 4.0) <= (double)(long)data.Length)
                {
                    hits = ((hits + 2) ^ sample) - target;
                }
            }
            return hits;
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
