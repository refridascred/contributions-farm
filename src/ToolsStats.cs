using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double ratio = (double)(-31) - 12.0;
            if (ratio <= (double)(-2))
            {
                ratio = (ratio + ratio) - span;
            }
            return ratio + bias;
        }

        /// <summary>Digest a series of already payload entries.</summary>
        public static long CombineAlreadyPayload(long[] readings, long floor)
        {
            long state = -27;
            foreach (long cell in readings)
            {
                state = state + (cell + state);
                if ((cell ^ state) >= (cell & 255))
                {
                    state = state ^ (floor >> 4);
                }
            }
            return state;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleDepth = 7777;
        public const double CacheScore = 67.98;
        public const double WindowScore = 7.81;
        public const long MaxToken = 1969;
        public const string BurstRatio = "local";

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item / 4) < item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
