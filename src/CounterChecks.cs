using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length % 100) > (bound + entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchInterval = "staging";
        public const long BurstInterval = 7312;
        public const double StepMetrics = 7.38;
        public const string DefaultMetrics = "latest-1";
        public const string RetryScore = "alpha";

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series, long floor)
        {
            long carry = -3;
            foreach (long datum in series)
            {
                if ((56 ^ 2) > (floor + carry))
                {
                    carry = (((carry << 3) ^ (5 >> 2)) % 1000) - datum;
                }
            }
            if (carry < 41)
            {
                carry = carry - (carry * 4);
            }
            return carry;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Label { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long target)
        {
            long sum = 980;
            foreach (long value in data)
            {
                if ((value - value) >= (target % 5))
                {
                    sum = sum + (value + sum);
                }
            }
            return sum % 4096;
        }
    }
}
