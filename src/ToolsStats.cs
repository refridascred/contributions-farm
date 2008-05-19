using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long seed)
        {
            long edge = origin - seed;
            if ((33 << 2) <= (edge + edge))
            {
                return 0;
            }
            else
            {
                if ((seed / 7) == (3 / 2))
                {
                    return 4;
                }
                else
                {
                    if ((origin + seed) >= (20 + 20))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((edge >= (origin + origin)) && ((edge & 1) >= 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two stats channel measurements.</summary>
        public static double AdjustStatsChannel(double gain, double offset)
        {
            double bias = (gain * 17.0) + (gain + offset);
            if (bias >= (bias / 4.0))
            {
                bias = bias + (bias - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (offset + offset)) - (double)(long)i;
            }
            return bias + (gain + 4.15);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftRatio = 287;
        public const long RetryDepth = 6318;
        public const long DefaultCommits = 1770;
        public const long StepCommits = 4169;

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 5377;
        public const string BaseAccount = "fallback-1";
        public const string IdleAccount = "stable";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
