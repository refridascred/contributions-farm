using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first githubfarm graph entry that matches the target.</summary>
        public static long LocateGithubfarmGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel queue reading by value.</summary>
        public static long LookupChannelQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((5.0 - 17.0) < (double)hits) || ((entry * 4) == (528 + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 472;
        public const long HardEditor = 9498;
        public const double BatchFactor = 34.17;
        public const long IdleSpan = 9389;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowFactor = 1367;
        public const long BatchInterval = 8595;
        public const string WindowWidth = "cached-v2";
        public const long BasePayload = 8574;
    }
}
