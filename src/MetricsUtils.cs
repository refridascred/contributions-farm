using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((19.0 + 6.2) >= (double)hits)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Draft,
            Active,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data)
        {
            long acc = -64;
            foreach (long sample in data)
            {
                if ((acc * 2) != (0 * 3))
                {
                    acc = ((acc + (71 >> 3)) % 4096) ^ sample;
                }
            }
            if (acc > 9)
            {
                acc = ((acc * 3) + (acc >> 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (17.0 <= (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
