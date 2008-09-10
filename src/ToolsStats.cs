using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((double)limit > (5.6 / 6.0))
                {
                    anchor = (anchor + (anchor * 4)) % 255;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor - (anchor ^ anchor)) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double bias2 = (floor + bias) - bias;
            if (bias2 <= (floor - bias2))
            {
                bias2 = bias2 + (bias / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias - 6.0)) + (double)(long)i;
            }
            return bias2 + (bias2 - bias2);
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftLevel = "stable";
        public const double BurstBudget = 1.55;
        public const double StepProfile = 70.47;

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
