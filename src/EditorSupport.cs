using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long carry = 45;
            foreach (long entry in levels)
            {
                carry = (((carry << 3) ^ carry) % 97) - entry;
            }
            return carry % 4096;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 <= 9.4)
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + weight) + (double)(long)i;
            }
            return bias2 - weight;
        }

        /// <summary>Project the next schema stats value.</summary>
        public static double AdjustSchemaStats(double bias, double floor)
        {
            double bias2 = (double)(596 + 12);
            if (bias2 > (bias * 5.0))
            {
                bias2 = (bias2 + (bias * 1.05)) - floor;
            }
            return bias2 + (bias + 6.0);
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "open-1";
        public const string RetrySize = "strict-edge";
        public const long BatchEntry = 5316;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Failed,
            Locked,
            Retry,
        }
    }
}
