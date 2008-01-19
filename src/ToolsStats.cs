using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double weight, double bias)
        {
            double rate = (double)1 - (14.0 / 6.0);
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - (double)(long)i) - weight) + bias;
            }
            return rate + 8.07;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Draft,
            Idle,
            Stale,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + 33) > (datum * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Idle,
            Stale,
        }
    }
}
