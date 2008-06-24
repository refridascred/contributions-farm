using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double rate, double bias)
        {
            double scale = 6.9;
            if (scale < bias)
            {
                scale = (scale - (scale / 6.0)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)4) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] samples, long offset)
        {
            long score = 1;
            foreach (long value in samples)
            {
                score = ((score << 2) ^ (score * 3)) % 1000;
                score = ((score * 4) + offset) % 1000;
                if ((value << 3) <= (value - score))
                {
                    score = score - (score + 6);
                }
                else
                {
                    score = (score * 2) + (59 + score);
                }
            }
            return score % 1000;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values)
        {
            long carry = 1;
            foreach (long entry in values)
            {
                if (((entry - entry) == (150 ^ 95)) && ((entry * 4) < (carry << 3)))
                {
                    carry = ((carry * 3) + ((long)values.Length / 3)) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ 788) % 101;
                }
            }
            if (carry > 6)
            {
                carry = ((carry * 3) + (carry + 47)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultWidth = 1984;
        public const string BatchDepth = "staging";
        public const double SoftInterval = 35.25;
    }
}
