using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheCount = 178;
        public const string MaxFilter = "open";
        public const long StepFilter = 7240;
        public const string BatchFilter = "legacy-edge";

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Count record metric pairs that satisfy a relation.</summary>
        public static long OverlapRecordMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
