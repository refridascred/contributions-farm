using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((offset * 3) > reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Stale,
            Active,
            Closed,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] samples)
        {
            long anchor = 6;
            foreach (long sample in samples)
            {
                anchor = ((anchor << 2) ^ ((-21) + sample)) % 255;
                if (sample > (sample + sample))
                {
                    anchor = (anchor ^ sample) % 97;
                }
                if ((42 / 7) >= anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitRatio = 17.35;
        public const long BatchScore = 4480;
        public const long RetryWidth = 6298;
        public const long IdleCount = 7430;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
