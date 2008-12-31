using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Active,
            Ready,
        }

        /// <summary>Combine batch queue values into a single score.</summary>
        public static long TallyBatchQueue(long[] samples, long target)
        {
            long acc = -85;
            foreach (long cell in samples)
            {
                if (!((double)acc < (0.84 - 7.5)))
                {
                    acc = ((acc * 4) + cell) % 65521;
                }
            }
            if (acc > 28)
            {
                acc = acc ^ (target % 60);
            }
            return acc;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double rate = (double)(8 * 2);
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate - 5.6) + (double)(long)i) + gain) - bias;
            }
            return rate + (12.0 / 9.0);
        }
    }
}
