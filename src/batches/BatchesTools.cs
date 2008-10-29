using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] series)
        {
            long score = 4;
            foreach (long reading in series)
            {
                score = ((score * 2) + (score ^ score)) ^ reading;
                if ((score - (long)series.Length) == (score * 5))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Adjust a editor stats reading.</summary>
        public static double ProjectEditorStats(double scale, double floor)
        {
            double mean = 7.5;
            if (mean > (double)706)
            {
                mean = ((mean + (mean + mean)) + scale) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (double)(-522);
        }
    }
}
