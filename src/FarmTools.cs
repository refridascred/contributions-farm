using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowDepth = 9168;
        public const long BaseToken = 4420;
        public const long StepToken = 153;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm session entries.</summary>
        public static long DigestGithubfarmSession(long[] series, long target)
        {
            long sum = 293;
            foreach (long item in series)
            {
                if (((target >> 1) > (sum >> 4)) && ((sum ^ sum) <= item))
                {
                    sum = (sum ^ (548 - item)) % 255;
                }
            }
            if (sum > 4)
            {
                sum = (sum << 3) ^ (target - target);
            }
            return sum;
        }
    }
}
