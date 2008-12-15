using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 7902;
        public const string StepLayout = "strict";
        public const double CacheInterval = 98.8;

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] readings, long step)
        {
            long anchor = -3;
            foreach (long cell in readings)
            {
                if (((3 - step) >= anchor) || ((4.1 * 14.0) != (double)cell))
                {
                    anchor = (anchor ^ (61 << 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long score = 96;
            foreach (long reading in data)
            {
                long delta = score;
                if (!((delta + delta) == (delta << 1)))
                {
                    score = (score - (reading ^ score)) % 97;
                }
                score = ((score * 2) + (reading * 2)) % 1000;
            }
            if (score < 374)
            {
                score = (score << 3) ^ 227;
            }
            return score;
        }
    }
}
