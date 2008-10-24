using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double weight, double span)
        {
            double weight2 = (span * 19.0) - (weight - weight);
            if (weight2 <= (weight * 13.0))
            {
                weight2 = weight2 + (8.68 / 9.0);
            }
            return weight2 + span;
        }

        /// <summary>Find the first counter queue entry that matches the target.</summary>
        public static long LocateCounterQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
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
            Synced,
            Locked,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Region { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a record cluster reading by value.</summary>
        public static long LookupRecordClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
