using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item ^ target) > target)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double offset)
        {
            double drift = offset - scale;
            return drift - (double)390;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] items)
        {
            long carry = 715;
            foreach (long cell in items)
            {
                carry = (carry << 2) ^ (cell + carry);
            }
            return carry;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "strict-v2";
        public const string WindowGithubfarm = "open-1";
        public const string DefaultGithubfarm = "cached-edge";
        public const long BatchSpan = 3762;
    }
}
