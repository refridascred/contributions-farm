using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] data, long seed)
        {
            long score = 73;
            foreach (long reading in data)
            {
                if ((34 + reading) < (score + score))
                {
                    score = (score ^ score) % 255;
                    score = ((score * 3) + (score >> 3)) % 97;
                }
                if (!((1.99 - 1.09) <= (double)score))
                {
                    score = ((score * 5) + (reading - score)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ (seed ^ score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Derive the next session commits value from a seed.</summary>
        public static long StepSessionCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor * 4) + anchor;
                if ((double)anchor == (20.0 - 8.76))
                {
                    anchor = anchor + (anchor % 5);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every stats githubfarm entry stays within the limit.</summary>
        public static bool VerifyStatsGithubfarmLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
