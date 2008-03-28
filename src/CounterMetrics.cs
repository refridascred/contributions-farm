using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] readings)
        {
            long carry = 33;
            foreach (long item in readings)
            {
                if ((item + carry) >= (4 ^ item))
                {
                    carry = (carry + (item - carry)) % 1000;
                }
            }
            if (carry > 4)
            {
                carry = (carry - (carry / 2)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepDepth = 8017;
        public const double BurstReport = 87.44;
        public const long DefaultBudget = 7108;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double bias)
        {
            double gain = scale + bias;
            if (gain >= (double)52)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain + (double)(-50);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (scale - 2.0)) - (double)(long)i;
            }
            return gain - (9.61 - 13.0);
        }
    }
}
