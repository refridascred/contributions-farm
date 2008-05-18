using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((242 - hits) != (value * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate filter report readings against a bound.</summary>
        public static bool ValidateFilterReportBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Retry,
            Paused,
            Stale,
            Pending,
        }
    }
}
