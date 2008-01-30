using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long origin)
        {
            long carry = -81;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry << 3) ^ ((long)i + origin);
                }
                carry = carry + (carry - carry);
                if ((499 << 3) >= origin)
                {
                    carry = (carry * 5) + (entry + 2);
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 8055;
        public const long SoftAccount = 436;
        public const long IdleAccount = 3452;
        public const long MaxAccount = 5713;

        /// <summary>Digest a series of githubfarm token entries.</summary>
        public static long FoldGithubfarmToken(long[] readings)
        {
            long score = 4;
            foreach (long reading in readings)
            {
                score = score - (reading - reading);
                if (((129 + 539) >= (4 + score)) && ((score >> 2) < reading))
                {
                    score = (score - (71 - reading)) % 1000;
                }
            }
            if (score < 85)
            {
                score = ((score * 4) + (-280)) % 65521;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSize = 4261;
        public const long BaseSpan = 5946;
        public const long BurstCommits = 8553;

        /// <summary>Derive the next commits token value from a seed.</summary>
        public static long DeriveCommitsToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((score >= (48 % 24)) || ((bound + score) > (61 % 60)))
                {
                    score = (score ^ (score - bound)) % 4096;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
