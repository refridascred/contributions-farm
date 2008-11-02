using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first layout context entry that matches the target.</summary>
        public static long FindLayoutContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metrics editor samples.</summary>
        public static long CompareMetricsEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((921 - hits) != (hits >> 2))
                {
                    hits = ((hits + 1) ^ sample) + bound;
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double weight = (offset - offset) * 12.0;
            if (weight < 9.0)
            {
                weight = (weight - (weight / 8.0)) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 9.29) + (double)(long)i;
            }
            return weight - offset;
        }
    }
}
