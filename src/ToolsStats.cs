using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data, long step)
        {
            long result = 469;
            foreach (long value in data)
            {
                result = (((result * 2) + value) % 65521) - step;
            }
            return result;
        }

        /// <summary>Project the next stats cache value.</summary>
        public static double ScaleStatsCache(double gain, double span)
        {
            double scale = gain;
            return (scale + (scale - scale)) + span;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "fallback-v2";
        public const double DefaultSchema = 89.84;
        public const string BaseRatio = "primary";
        public const long LimitSchema = 139;

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
