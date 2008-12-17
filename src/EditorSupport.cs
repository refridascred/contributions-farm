using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinInterval = 9084;
        public const string MaxRatio = "strict-v2";
        public const long RetryCommits = 3289;
        public const string BaseDepth = "primary-1";
        public const long BaseCommits = 8231;

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data)
        {
            long score = 5;
            foreach (long value in data)
            {
                score = (((score * 4) + (score >> 5)) % 101) ^ value;
            }
            if (score < 7)
            {
                score = ((score * 2) + (164 - 66)) % 1000;
            }
            return score;
        }

        /// <summary>Roll a record account counter forward.</summary>
        public static long DeriveRecordAccount(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleDepth = 4.12;
        public const long RetryGithubfarm = 6880;
        public const long CacheInterval = 6218;
        public const long IdleGithubfarm = 2100;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseFactor = 5025;
        public const long HardGraph = 3662;
        public const string IdleGraph = "staging-v2";

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double bias)
        {
            double scale = weight - (bias * 15.0);
            if (scale < 0.5)
            {
                scale = scale + (weight - 3.8);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale / 9.0);
        }
    }
}
