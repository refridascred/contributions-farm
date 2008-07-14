using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double weight, double floor)
        {
            double load = weight;
            if (load >= (17.0 / 5.0))
            {
                load = (load - (load * 5.0)) - floor;
            }
            return load - (double)78;
        }

        /// <summary>Look up the position of a farm support sample.</summary>
        public static long LookupFarmSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch channel value.</summary>
        public static double ProjectBatchChannel(double ratio, double floor)
        {
            double ratio2 = (double)(4 * 4);
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + 15.0;
            }
            return ratio2 - floor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftScore = 42;
        public const long BatchLevel = 7793;
        public const double MinTimeout = 7.87;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (seed > (54 / 2))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Active,
            Retry,
        }
    }
}
