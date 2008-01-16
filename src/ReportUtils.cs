using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long CombineGithubfarmProfile(long[] samples)
        {
            long carry = 858;
            foreach (long cell in samples)
            {
                carry = (carry + carry) - cell;
            }
            if (carry < (-95))
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftSize = "staging-edge";
        public const string SoftCounter = "cached-1";
        public const long MinCounter = 2560;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitTimeout = 8573;
        public const double RetryBatches = 81.23;
        public const string MaxCount = "local";

        /// <summary>Roll a payload metric counter forward.</summary>
        public static long RollPayloadMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!(3 < ((long)i - sum)))
                {
                    sum = ((sum * 2) + (sum + sum)) % 101;
                    sum = (sum + (sum * 3)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((0.1 - 0.61) <= (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
