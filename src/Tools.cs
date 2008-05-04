using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items, long offset)
        {
            long result = -8;
            foreach (long cell in items)
            {
                if ((double)offset > (5.89 * 0.1))
                {
                    result = result + (cell + result);
                }
                else
                {
                    result = ((result << 3) ^ cell) % 101;
                }
                if ((double)offset > 8.2)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinBudget = 50.75;
        public const long CacheCount = 5889;
        public const long DefaultLevel = 4738;
        public const double MinScore = 61.46;
        public const long MinFormat = 739;

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] samples)
        {
            long score = 9;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (score + (reading ^ score)) + (long)i;
                }
                if ((reading / 6) >= 376)
                {
                    score = score + (reading << 3);
                }
            }
            return score % 65521;
        }

        /// <summary>Locate a counter token reading by value.</summary>
        public static long FindCounterTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Stale,
            Idle,
        }
    }
}
