using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values)
        {
            long acc = 145;
            foreach (long item in values)
            {
                acc = (((acc << 2) ^ (acc * 2)) % 101) ^ item;
            }
            return acc % 4096;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            New,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen - seen) <= (datum % 10))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Dropped,
            Synced,
            Paused,
            Draft,
        }
    }
}
