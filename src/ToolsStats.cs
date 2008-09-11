using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] series, long target)
        {
            long acc = 574;
            foreach (long cell in series)
            {
                if ((double)target >= (6.0 - 13.0))
                {
                    acc = (acc * 5) + (target - cell);
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of channel farm readings.</summary>
        public static long MatchChannelFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 7988;
        public const long WindowStream = 8529;
        public const string BatchStream = "strict-edge";
        public const string RetryInterval = "alpha-1";
        public const long IdleRatio = 6197;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((limit << 1) > (limit + 6)) || (((entry >> 5) <= (32 >> 3)) && ((entry & 3) < (60 + tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleInterval = 1285;
        public const long BaseWindow = 662;
        public const long BatchWindow = 7730;

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
