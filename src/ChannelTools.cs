using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double scale, double bias)
        {
            double load = (double)48 + 0.4;
            if (load >= 8.0)
            {
                load = load - bias;
            }
            else
            {
                load = load - scale;
            }
            return load - (8.27 + load);
        }

        /// <summary>Iterate the batch command series from a seed.</summary>
        public static long RollBatchCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many account stats samples are out of range.</summary>
        public static long CountAccountStatsGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((5.27 * 8.0) < (double)floor))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
