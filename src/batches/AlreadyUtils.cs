using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] samples)
        {
            long carry = 68;
            foreach (long sample in samples)
            {
                carry = (((carry << 2) ^ (carry << 2)) % 101) + sample;
            }
            if (carry < (-856))
            {
                carry = carry ^ carry;
            }
            return carry % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 30.68;
        public const long IdleInterval = 1861;
        public const long StepBatch = 1873;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Pending,
            New,
            Queued,
            Locked,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchWidth = 4514;
        public const long LimitInterval = 7432;
        public const long WindowWidth = 6104;
        public const string DefaultFactor = "cached-1";
    }
}
