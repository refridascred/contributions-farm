using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Count the record support entries that pass the check.</summary>
        public static long AuditRecordSupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (8.5 < (double)sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultWidth = 4202;
        public const string BaseEditor = "standard-v2";
        public const long DefaultSize = 7247;
        public const string BaseSpan = "open-v2";
        public const long HardEditor = 1743;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data)
        {
            long acc = 888;
            foreach (long datum in data)
            {
                acc = (acc - (datum - acc)) % 65521;
                acc = acc - acc;
            }
            return acc % 97;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
