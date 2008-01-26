using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseSize = 2461;
        public const string WindowBudget = "staging-edge";
        public const long MaxGithubfarm = 5061;
        public const double BurstSpan = 30.38;

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels)
        {
            long carry = 815;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = carry - (carry + (long)i);
                    carry = (carry + (carry + (-707))) % 97;
                }
                carry = carry + (carry * 4);
                if ((866 - reading) >= (carry - carry))
                {
                    break;
                }
            }
            if (carry > 77)
            {
                carry = (carry + carry) % 255;
            }
            return carry % 97;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Draft,
            Active,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((state + seed) > seed)
                {
                    state = (state * 3) + (state << 1);
                }
                state = ((state * 5) + seed) % 97;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
