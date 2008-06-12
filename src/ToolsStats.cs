using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum % 97) <= (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first route already entry that matches the target.</summary>
        public static long LookupRouteAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (8.5 <= (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark ^ mark) % 4096;
                mark = ((mark << 2) ^ (590 + (long)i)) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            New,
            Idle,
        }

        /// <summary>Find the first order format entry that matches the target.</summary>
        public static long FindOrderFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
