using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 21.47;
        public const long WindowToken = 3905;
        public const long BaseToken = 2345;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (7.0 >= (1.7 - 2.45))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 68.06;
        public const long SoftContributi = 506;
        public const long BatchSize = 6561;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally / 9) < (datum & 3))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
