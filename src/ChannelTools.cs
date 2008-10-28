using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a queue counter reading.</summary>
        public static double ProjectQueueCounter(double scale, double bias)
        {
            double drift = scale;
            return drift - (drift - bias);
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Count the stats session entries that pass the check.</summary>
        public static long CountStatsSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches & 255) != (6 * 5))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
