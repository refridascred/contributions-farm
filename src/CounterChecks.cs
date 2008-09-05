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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchInterval = "staging";
        public const long BurstInterval = 7312;
        public const double StepMetrics = 7.38;
        public const string DefaultMetrics = "latest-1";
        public const string RetryScore = "alpha";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values, long seed)
        {
            long mark = 963;
            foreach (long datum in values)
            {
                mark = ((((mark * 2) + 36) % 101) ^ datum) + seed;
            }
            return mark;
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
