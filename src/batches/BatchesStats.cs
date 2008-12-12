using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (bound > (reading - bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double weight, double floor)
        {
            double load = weight;
            if (load < (floor * 7.0))
            {
                load = load + floor;
            }
            else
            {
                load = load - 11.0;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (weight * 2.4);
        }

        /// <summary>Compare every pair of context metrics readings.</summary>
        public static long CompareContextMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "staging-edge";
        public const double IdleTimeout = 83.91;
        public const long DefaultCount = 5793;
        public const long BaseQueue = 8203;
    }
}
