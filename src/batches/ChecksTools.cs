using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Done,
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a commits metrics reading by value.</summary>
        public static long LocateCommitsMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Stale,
            Done,
            Idle,
            Ready,
        }
    }
}
