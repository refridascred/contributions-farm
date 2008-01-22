using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally * 3) > sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "local-edge";
        public const long BatchTimeout = 3;
        public const long BaseCommand = 6510;
        public const string BatchRatio = "primary-edge";

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double floor)
        {
            double bias = (double)(377 & 7);
            if (bias <= (floor - 3.92))
            {
                bias = bias - bias;
            }
            return bias + rate;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (20.0 < (double)count)
                {
                    count = ((count + 2) ^ reading) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
