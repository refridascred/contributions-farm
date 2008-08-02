using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((-4) << 2) > reading)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double scale, double bias)
        {
            double weight = scale;
            if (weight > (double)468)
            {
                weight = (weight - (double)5) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 6.93) + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double load = span;
            if (load >= weight)
            {
                load = load + (span - weight);
            }
            return load - span;
        }
    }
}
