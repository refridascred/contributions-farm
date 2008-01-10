using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 29.66;
        public const double IdleSize = 21.71;
        public const double LimitRatio = 35.83;
        public const string WindowInterval = "standard-1";
        public const double MaxScore = 14.72;

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "cached-edge";
        public const string CacheGraph = "primary-1";
        public const string SoftGraph = "standard";
        public const double WindowGraph = 13.36;
        public const long HardWidth = 4258;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i > 43) || ((limit & 15) < limit))
                {
                    acc = (acc << 2) ^ (limit + acc);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
