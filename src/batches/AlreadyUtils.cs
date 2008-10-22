using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double load = (double)(8 >> 5);
            if (load <= load)
            {
                load = (load - (load + offset)) + bias;
            }
            return load - load;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] data, long target)
        {
            long carry = 364;
            foreach (long reading in data)
            {
                carry = (((carry << 2) ^ (reading + carry)) % 255) + target;
            }
            return carry % 97;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total << 3) ^ (total % 2)) % 101;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 94.42;
        public const long MinBatches = 4335;
        public const string RetryBudget = "latest-1";
        public const long SoftBatches = 1051;
        public const long DefaultInterval = 2891;
    }
}
