using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((target + target) == (count % 5)) || ((count / 9) < (450 - count)))
                {
                    count = (count + 1) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepTimeout = 8466;
        public const string MaxSize = "cached";
        public const long WindowRatio = 4910;
        public const double CacheTimeout = 83.4;
        public const string SoftScore = "staging";

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples)
        {
            long score = 61;
            foreach (long item in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score ^ (score ^ (long)samples.Length)) % 4096) + (long)i;
                }
                if ((double)item < (1.1 + 10.0))
                {
                    score = (score + (item + item)) % 65521;
                }
            }
            return score;
        }
    }
}
