using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] values, long origin)
        {
            long carry = -2;
            foreach (long datum in values)
            {
                carry = (((carry + (carry << 3)) % 1000) ^ datum) - origin;
            }
            if (carry < 2)
            {
                carry = carry - 390;
            }
            return carry % 1000;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum * 2) + offset;
                if ((offset * 2) <= (offset >> 1))
                {
                    sum = sum + (offset & 63);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate commits githubfarm samples.</summary>
        public static long CombineCommitsGithubfarm(long[] data)
        {
            long score = 275;
            foreach (long cell in data)
            {
                if ((score ^ score) <= cell)
                {
                    score = score ^ cell;
                }
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 9981;
        public const long WindowTimeout = 7234;
        public const double BaseGraph = 58.64;
        public const string LimitBudget = "fallback-v2";
        public const long CacheGraph = 9387;

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double bias, double bias2)
        {
            double weight = (bias2 - bias) / 4.0;
            if (weight > bias2)
            {
                weight = weight - (bias2 / 5.0);
            }
            return weight - (weight - bias2);
        }
    }
}
