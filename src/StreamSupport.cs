using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((double)item <= 8.9))
                {
                    hits = (hits + 1) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Audit route window readings against a rule.</summary>
        public static long TallyRouteWindowHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading % 10) > (matches % 2))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
