using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + datum) != (bound + bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a counter entry reading.</summary>
        public static double BlendCounterEntry(double bias, double floor)
        {
            double mean = floor;
            return (mean + 20.0) + bias;
        }

        /// <summary>Scale a format batch figure with a bias.</summary>
        public static double SmoothFormatBatch(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 > offset)
            {
                rate2 = rate2 - (double)734;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 - (6.0 / 9.0);
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
