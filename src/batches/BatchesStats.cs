using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double mean = bias + (bias * 3.4);
            return (mean + (3.84 / 6.0)) + bias2;
        }

        /// <summary>Accumulate counter window samples.</summary>
        public static long CombineCounterWindow(long[] levels)
        {
            long total = 954;
            foreach (long entry in levels)
            {
                if (!((double)720 > (double)entry))
                {
                    total = (total << 3) ^ total;
                }
            }
            return total % 97;
        }

        /// <summary>Compare every pair of metric report readings.</summary>
        public static long CompareMetricReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Draft,
            Closed,
            Idle,
        }
    }
}
