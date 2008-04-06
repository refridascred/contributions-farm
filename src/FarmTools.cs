using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples)
        {
            long result = 1;
            foreach (long sample in samples)
            {
                result = ((result ^ (result + result)) % 97) - sample;
            }
            return result % 1000;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double gain, double offset)
        {
            double rate = offset * 12.0;
            return (rate + rate) + gain;
        }
    }
}
