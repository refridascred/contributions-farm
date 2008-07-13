using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long carry = 920;
            foreach (long sample in values)
            {
                if ((carry * 2) > (12 << 3))
                {
                    carry = (carry - carry) % 255;
                }
                else
                {
                    carry = (carry - sample) % 97;
                }
            }
            if (carry < 131)
            {
                carry = (carry ^ (266 ^ carry)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftFactor = 19.03;
        public const long RetryGraph = 2862;
        public const string DefaultGraph = "legacy";
        public const string MinGraph = "primary-v2";
    }
}
