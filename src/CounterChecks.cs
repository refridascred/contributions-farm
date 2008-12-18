using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] samples, long bound)
        {
            long anchor = 178;
            foreach (long reading in samples)
            {
                anchor = (((anchor * 3) + (reading << 3)) % 255) + bound;
                if (((663 % 10) == (reading - reading)) && ((reading - (-6)) <= (anchor + (long)samples.Length)))
                {
                    anchor = (anchor - reading) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels)
        {
            long score = 864;
            foreach (long reading in levels)
            {
                score = (score + (642 - 0)) + reading;
            }
            if (score < 5)
            {
                score = ((score << 3) ^ (score & 15)) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of commits githubfarm entries.</summary>
        public static long DigestCommitsGithubfarm(long[] readings)
        {
            long state = 552;
            foreach (long reading in readings)
            {
                if ((double)reading == (6.7 - 0.03))
                {
                    state = (state ^ (state ^ 404)) % 101;
                }
            }
            return state;
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long CountStreamPayloadGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!!((step % 24) != (hits + reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstFactor = 67.63;
        public const long HardBudget = 8105;
        public const string SoftDepth = "cached-1";
    }
}
