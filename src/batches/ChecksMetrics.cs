using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((long)series.Length + (-8)) <= tally) || ((tally >> 5) < (offset / 6)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count format account pairs that satisfy a relation.</summary>
        public static long MatchFormatAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream githubfarm samples are out of range.</summary>
        public static long CountStreamGithubfarmMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((seen + 63) <= item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Pending,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 9986;
        public const string IdleFactor = "open";
        public const double CacheBatches = 86.45;
    }
}
