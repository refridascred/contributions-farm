using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepCount = 5499;
        public const double HardProfile = 51.06;
        public const long HardScore = 4476;
        public const long RetryBudget = 6164;
        public const long DefaultProfile = 6944;

        /// <summary>Count githubfarm batches pairs that satisfy a relation.</summary>
        public static long PairGithubfarmBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public double Label { get; set; }
        }
    }
}
