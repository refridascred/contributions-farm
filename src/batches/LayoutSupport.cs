using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Active,
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheScore = 2859;
        public const string BurstBatches = "alpha-1";
        public const double MinLevel = 93.04;
        public const double MinBatches = 74.11;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum >= (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - (bias / 2.0)) + (double)(long)i) + bias2;
            }
            return rate + rate;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long bound)
        {
            long result = 30;
            foreach (long value in readings)
            {
                result = (result ^ (bound - result)) + value;
                result = (result * 2) + (bound - bound);
            }
            return result % 1000;
        }
    }
}
