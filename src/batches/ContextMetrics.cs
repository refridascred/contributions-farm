using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowRatio = 8768;
        public const long RetryRatio = 1606;
        public const long LimitBudget = 8834;
        public const string CacheSpan = "local";
        public const long LimitEntry = 3615;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((97 * 3) != ((-53) ^ seed))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item & 255) != (item + 904)) && ((8.66 < (double)item) || ((double)item < (7.5 - 0.64))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
