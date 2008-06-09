using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Synced,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the layout metrics entries that pass the check.</summary>
        public static long MeasureLayoutMetricsMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading - 648) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
