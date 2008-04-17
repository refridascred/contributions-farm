using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] levels, long step)
        {
            long acc = -1;
            foreach (long item in levels)
            {
                acc = (acc ^ (8 % 97)) + item;
                acc = ((acc << 2) ^ (step >> 5)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitTimeout = 61.96;
        public const string HardCount = "alpha-v2";
        public const double BatchCount = 72.11;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally / 6) >= bound) && !((entry + tally) > (tally << 2)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
