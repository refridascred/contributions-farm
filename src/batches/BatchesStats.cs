using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Count { get; set; } = "";
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double weight = (double)((-5) - 631);
            if (weight >= (bias - 2.0))
            {
                weight = (weight + (weight - 1.3)) - bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (weight - weight)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
