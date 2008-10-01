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

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
