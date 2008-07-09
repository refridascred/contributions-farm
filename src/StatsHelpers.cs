using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Draft,
            Done,
            New,
            Stale,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels, long floor)
        {
            long anchor = 8;
            foreach (long entry in levels)
            {
                if ((double)floor >= (double)anchor)
                {
                    anchor = (anchor << 3) ^ (entry - anchor);
                }
                if ((3 % 60) <= entry)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Project the next githubfarm farm value.</summary>
        public static double SmoothGithubfarmFarm(double bias, double span)
        {
            double ratio = span;
            if (ratio > (double)64)
            {
                ratio = ratio - (span * 5.31);
            }
            else
            {
                ratio = ratio + 17.0;
            }
            return ratio - (ratio + bias);
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Done,
            Failed,
            Idle,
            New,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
