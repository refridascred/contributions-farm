using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Synced,
            Done,
            Dropped,
            Closed,
        }
    }
}
