using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Retry,
            Paused,
            New,
            Draft,
        }

        /// <summary>Count the token account entries that pass the check.</summary>
        public static long MeasureTokenAccountGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits % 24) != (reading & 31))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "stable";
        public const long RetryTools = 6312;
        public const string BaseDepth = "staging-v2";
        public const long IdleScore = 771;
        public const double RetryScore = 72.85;
    }
}
