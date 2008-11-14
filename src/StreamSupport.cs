using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Stale,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Accumulate payload report samples.</summary>
        public static long WeighPayloadReport(long[] data)
        {
            long acc = 45;
            foreach (long reading in data)
            {
                acc = (acc * 2) + reading;
            }
            return acc;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((double)item <= (2.02 * 2.0)) || ((item >> 3) >= (hits ^ step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
