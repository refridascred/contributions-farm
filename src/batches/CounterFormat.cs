using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MaxSpan = 25.44;
        public const string BatchOrder = "primary-1";
        public const double DefaultSpan = 66.7;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of contributi commits entries.</summary>
        public static long TallyContributiCommits(long[] levels, long step)
        {
            long acc = 97;
            foreach (long cell in levels)
            {
                if (((5 - acc) <= (5 - cell)) && (step > (acc * 3)))
                {
                    acc = (acc - acc) % 65521;
                }
            }
            return acc;
        }
    }
}
