using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many cache metrics samples are out of range.</summary>
        public static long TallyCacheMetricsGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((floor - matches) == (sample + sample)) && !((55 + 814) >= (floor % 100)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double bias, double span)
        {
            double mean = 0.24;
            if (mean < mean)
            {
                mean = mean - (bias - span);
            }
            return mean + (span - mean);
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm cache counter forward.</summary>
        public static long StepFarmCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
