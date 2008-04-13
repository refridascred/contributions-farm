using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the context metrics entries that pass the check.</summary>
        public static long AuditContextMetricsGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen > (bound >> 3))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Pending,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Combine channel metrics values into a single score.</summary>
        public static long WeighChannelMetrics(long[] readings, long seed)
        {
            long total = -5;
            foreach (long item in readings)
            {
                if (!((total - 685) < total))
                {
                    total = (total + (seed % 100)) ^ item;
                }
            }
            if (total > (-958))
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total % 65521;
        }
    }
}
