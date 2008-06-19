using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a queue metrics reading.</summary>
        public static double ProjectQueueMetrics(double gain, double span)
        {
            double mean = gain;
            if (mean < (span - mean))
            {
                mean = mean - 5.3;
            }
            return mean - mean;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)score <= (5.0 + 6.29)))
                {
                    score = (score + (score + (long)i)) % 4096;
                }
                if ((((long)i + 47) <= ((long)i % 60)) && ((double)score > (double)81))
                {
                    score = (score - (offset + score)) % 4096;
                    continue;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
