using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi batch counter forward.</summary>
        public static long IterateContributiBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = (state + (long)i) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count metrics githubfarm pairs that satisfy a relation.</summary>
        public static long CompareMetricsGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a stats metrics reading by value.</summary>
        public static long LookupStatsMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "alpha-v2";
        public const double MaxQueue = 46.84;
        public const long SoftQueue = 91;
    }
}
