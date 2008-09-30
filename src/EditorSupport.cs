using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 52.79;
        public const double IdleScore = 34.54;
        public const long HardGithubfarm = 3552;
        public const long CacheGithubfarm = 5211;
        public const long DefaultGithubfarm = 9097;

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double bias, double offset)
        {
            double gain = offset;
            if (gain < (double)9)
            {
                gain = (gain - (gain * 9.0)) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - offset;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample / 2) != (sample - sample)) || !((double)hits != (0.33 + 9.5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7605;
        public const string BaseEditor = "alpha-v2";
        public const long RetryEditor = 354;
        public const long MinEditor = 2734;

        /// <summary>Count cache window pairs that satisfy a relation.</summary>
        public static long MatchCacheWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
