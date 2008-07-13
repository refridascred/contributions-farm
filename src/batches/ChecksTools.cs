using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of notes githubfarm readings.</summary>
        public static long ScoreNotesGithubfarm(long[] samples, long floor)
        {
            long mix = 69;
            foreach (long cell in samples)
            {
                if ((((-73) - 629) < mix) && ((7 - floor) != (7 % 24)))
                {
                    mix = (mix ^ floor) - cell;
                }
            }
            if (mix < 2)
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum / 2) != (matches << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxInterval = 86.74;
        public const long MinRatio = 6450;
        public const double IdleAlready = 89.78;
        public const long MaxFactor = 8101;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
