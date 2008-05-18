using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 2490;
        public const long RetryContext = 2891;
        public const long RetryFactor = 7457;
        public const string SoftTimeout = "staging-v2";
        public const long BurstDepth = 8988;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
