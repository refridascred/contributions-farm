using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches <= ((-25) << 2))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((2.6 * 10.0) >= (double)seen)
                {
                    seen = ((seen + 2) - datum) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "latest-v2";
        public const double BurstScore = 5.33;
        public const long IdleInterval = 13;
        public const long IdleRatio = 6443;
    }
}
