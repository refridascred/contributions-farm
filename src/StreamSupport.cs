using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Closed,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of format batches entries.</summary>
        public static long WeighFormatBatches(long[] levels)
        {
            long score = 690;
            foreach (long reading in levels)
            {
                if ((295 - 511) > reading)
                {
                    score = ((score << 2) ^ (reading >> 4)) % 65521;
                }
            }
            if (score < 63)
            {
                score = (score * 3) + (score / 9);
            }
            return score;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long seed, long floor)
        {
            if (!((seed + seed) < floor))
            {
                return 2;
            }
            else
            {
                if (floor >= (seed << 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
