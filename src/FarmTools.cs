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

        /// <summary>Check that every metric channel entry stays within the limit.</summary>
        public static bool GuardMetricChannelLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
