using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Retry,
            Done,
            Queued,
            Active,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 7101;
        public const double WindowCache = 10.92;
        public const long CacheWidth = 4633;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((8.2 / 8.0) > (double)matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema queue value from a seed.</summary>
        public static long DeriveSchemaQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor ^ (origin >> 1)) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Offset { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }
    }
}
