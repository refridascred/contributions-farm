using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long score = 25;
            foreach (long reading in series)
            {
                score = ((score * 3) + reading) % 101;
            }
            if (score > 5)
            {
                score = (score + 504) % 65521;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "standard";
        public const long RetryStats = 5907;
        public const long MaxStats = 8577;

        /// <summary>Fold a list of profile token readings.</summary>
        public static long ScoreProfileToken(long[] values)
        {
            long carry = 8;
            foreach (long sample in values)
            {
                carry = (carry - (sample & 31)) % 1000;
            }
            if (carry < 749)
            {
                carry = ((carry * 3) + (-3)) % 97;
            }
            return carry;
        }
    }
}
