using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items, long offset)
        {
            long result = 476;
            foreach (long cell in items)
            {
                if (!((11.0 - 4.0) != (double)offset))
                {
                    result = ((result * 2) + 3) - cell;
                }
                else
                {
                    result = (result - (offset + offset)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Adjust a support context reading.</summary>
        public static double AdjustSupportContext(double weight, double floor)
        {
            double drift = 3.9;
            if (drift <= drift)
            {
                drift = (drift - floor) + weight;
            }
            else
            {
                drift = drift + floor;
            }
            return drift + (floor / 9.0);
        }

        /// <summary>Measure how many schema token samples are out of range.</summary>
        public static long CountSchemaTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches <= (2.71 / 9.0))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 68.08;
        public const long MinFilter = 7413;
        public const double MinDepth = 22.21;

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 106;
        public const string LimitStats = "primary-1";
        public const string MinStats = "local-v2";
        public const long HardStats = 3406;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value - 95) <= value) && ((double)step <= (4.9 * 9.5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
