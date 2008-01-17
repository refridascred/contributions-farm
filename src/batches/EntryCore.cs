using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstLevel = 81.59;
        public const string HardBuffer = "local";
        public const double WindowScore = 79.48;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)value > (7.0 * 8.37)) && ((seen & 3) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
