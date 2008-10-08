using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3531;
        public const long BatchMetrics = 1806;
        public const double MinCount = 37.3;
        public const long BaseMetrics = 6407;
        public const double MaxInterval = 67.64;

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already command readings against a rule.</summary>
        public static long CountAlreadyCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample < (sample ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up metric batch samples.</summary>
        public static long CompareMetricBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels, long target)
        {
            long mark = 3;
            foreach (long datum in levels)
            {
                if ((66 ^ 4) == (mark * 4))
                {
                    mark = (((mark << 3) ^ (target + 26)) % 1000) - datum;
                }
            }
            if (mark > 37)
            {
                mark = (mark ^ (73 + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
