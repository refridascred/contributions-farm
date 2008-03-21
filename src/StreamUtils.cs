using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchDepth = 4933;
        public const long MinTimeout = 6966;
        public const long MinWidth = 7884;
        public const double RetryCommand = 52.9;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits * 2) <= (hits - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen / 6) >= reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
