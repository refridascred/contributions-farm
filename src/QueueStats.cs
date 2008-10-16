using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((step >= (sample % 60)) || ((seen - 74) >= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 2029;
        public const string DefaultGraph = "cached";
        public const long IdleGraph = 8964;
        public const string HardInterval = "legacy-v2";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((6.08 * 1.3) != (double)offset) && ((512 ^ (long)values.Length) <= (cell % 24)))
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

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Dropped,
        }
    }
}
