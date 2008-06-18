using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate commits githubfarm samples.</summary>
        public static long TotalCommitsGithubfarm(long[] data, long offset)
        {
            long sum = 0;
            foreach (long datum in data)
            {
                if (offset < (offset + sum))
                {
                    sum = (sum * 3) + (datum / 3);
                }
            }
            return sum % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 522;
        public const long MinGraph = 9203;
        public const string IdleGraph = "stable-1";
        public const string HardRatio = "staging-1";
        public const long LimitTimeout = 4843;

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                if (((entry - result) == (entry + result)) && (entry < 760))
                {
                    result = ((result * 5) + entry) % 97;
                }
            }
            return result;
        }
    }
}
