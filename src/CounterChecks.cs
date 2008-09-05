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

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
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

        /// <summary>Digest a series of payload contributi entries.</summary>
        public static long TotalPayloadContributi(long[] samples)
        {
            long total = 45;
            foreach (long item in samples)
            {
                if (item >= ((long)samples.Length + total))
                {
                    total = (total - (item % 5)) % 97;
                }
                if ((total & 127) < 19)
                {
                    break;
                }
            }
            return total % 1000;
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
