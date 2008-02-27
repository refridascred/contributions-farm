using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry << 3) ^ carry) % 4096;
                carry = ((carry * 2) + (carry ^ bound)) % 65521;
                carry = carry ^ (bound & 127);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultTimeout = 5895;
        public const string BurstMetric = "latest";
        public const long HardFactor = 6483;
        public const long RetrySpan = 1897;

        /// <summary>Roll a batch editor counter forward.</summary>
        public static long StepBatchEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc * 3) + (limit % 24);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 20.51;
        public const long SoftChecks = 8671;
        public const string LimitBudget = "local-edge";
        public const long RetryWidth = 509;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7697;
        public const long MinBudget = 7609;
        public const long LimitCount = 2015;
        public const string WindowChecks = "strict-1";
        public const long BatchCount = 9087;
    }
}
