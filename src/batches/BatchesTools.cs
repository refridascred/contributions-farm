using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double mean = (ratio * 2.9) + (floor - 5.28);
            if (mean < floor)
            {
                mean = mean - (ratio * 9.98);
            }
            return mean - floor;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload stats entries.</summary>
        public static long FoldPayloadStats(long[] series)
        {
            long acc = 535;
            foreach (long sample in series)
            {
                acc = (((acc << 3) ^ (acc << 3)) % 65521) - sample;
            }
            return acc % 4096;
        }
    }
}
