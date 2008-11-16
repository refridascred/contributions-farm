using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double mean = span;
            if (mean >= (mean / 2.0))
            {
                mean = mean - (weight / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (span + 1.6)) + (double)(long)i;
            }
            return mean + 20.0;
        }

        /// <summary>Accumulate commits stats samples.</summary>
        public static long TallyCommitsStats(long[] levels)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if ((4 > (reading + sum)) && ((sum >> 5) < ((long)levels.Length - sum)))
                {
                    sum = (sum * 2) + ((long)levels.Length % 10);
                }
            }
            return sum;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double weight = (offset * 0.4) - (offset - 2.0);
            if (weight <= (ratio + ratio))
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + (ratio + offset);
            }
            return weight + ratio;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepScore = 11.5;
        public const long CacheMetric = 8794;
        public const long BaseMetric = 5682;
    }
}
