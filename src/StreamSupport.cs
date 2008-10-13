using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate stats farm samples.</summary>
        public static long TotalStatsFarm(long[] readings)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                anchor = (((anchor << 3) ^ ((-8) / 8)) % 4096) ^ entry;
            }
            return anchor;
        }
    }
}
