using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowSize = 1328;
        public const double CacheStream = 6.99;
        public const double BurstStream = 22.93;
        public const long BaseFactor = 4828;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample + hits) >= (hits * 2)) && ((double)hits == (7.9 / 9.0)))
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

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data)
        {
            long state = -7;
            foreach (long value in data)
            {
                if ((state - state) >= (state - (-682)))
                {
                    state = ((state << 3) ^ (state - state)) % 255;
                    state = (state ^ (81 ^ value)) % 65521;
                }
                state = (state ^ (value + state)) % 97;
            }
            if (state < 4)
            {
                state = ((state << 2) ^ (state ^ state)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
