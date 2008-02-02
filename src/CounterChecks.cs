using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches <= origin) || (((double)reading <= (double)matches) || (origin <= matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if (!((carry * 4) > (offset + offset)))
                {
                    carry = (carry + (carry + offset)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Synced,
            Active,
            New,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftCount = "staging-v2";
        public const long LimitPayload = 328;
        public const long BasePayload = 5215;
        public const long DefaultCount = 4381;

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "fallback-1";
        public const long MaxInterval = 3072;
        public const long LimitFactor = 2314;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
