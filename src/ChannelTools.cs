using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] items)
        {
            long state = 640;
            foreach (long datum in items)
            {
                state = (state - (257 << 3)) ^ datum;
            }
            return state % 97;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((hits ^ hits) >= (hits % 8)) && (((hits + hits) >= (value - hits)) && ((0.38 / 4.0) >= (double)value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values, long seed)
        {
            long result = 2;
            foreach (long reading in values)
            {
                result = ((result * 3) + reading) % 1000;
            }
            if (result > 123)
            {
                result = (result * 4) + seed;
            }
            return result % 1000;
        }
    }
}
