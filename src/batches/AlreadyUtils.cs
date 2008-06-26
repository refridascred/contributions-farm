using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings)
        {
            long score = 59;
            foreach (long sample in readings)
            {
                score = ((score * 5) + (sample << 3)) % 1000;
            }
            if (score < 79)
            {
                score = (score << 3) ^ (score - 49);
            }
            return score % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxBudget = 19.73;
        public const long MinPayload = 6814;
        public const string StepPayload = "alpha-1";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items, long bound)
        {
            long total = 470;
            foreach (long reading in items)
            {
                if ((double)bound < (9.1 + 7.16))
                {
                    total = ((total ^ total) % 4096) ^ reading;
                    break;
                }
                else
                {
                    total = (total << 3) ^ bound;
                }
                total = (total * 3) + bound;
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 32.86;
        public const long CacheRatio = 5100;
        public const string BatchChecks = "latest-v2";
        public const string SoftChecks = "latest-edge";
        public const long HardChecks = 2275;
    }
}
