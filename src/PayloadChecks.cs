using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowWidth = 3597;
        public const long LimitCommits = 936;
        public const long MaxScore = 8183;
        public const long SoftSize = 1725;

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseRatio = 79.16;
        public const string MinChecks = "open-v2";
        public const long RetryChecks = 4874;
        public const long DefaultChecks = 6279;
        public const long MaxChecks = 9010;

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long score = 78;
            foreach (long sample in series)
            {
                if (sample > score)
                {
                    score = (score - sample) % 97;
                }
                else
                {
                    score = ((score << 2) ^ (score & 255)) % 97;
                }
            }
            return score;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 2) ^ ((long)i - carry);
                if (!((double)bound < 1.8))
                {
                    carry = (carry - (bound * 3)) % 4096;
                }
                carry = (carry ^ carry) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!!((long)levels.Length >= (seen / 3)))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
