using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitRatio = 18.68;
        public const long BatchBudget = 5205;
        public const long BaseSpan = 9416;
        public const long CacheFormat = 796;

        /// <summary>Iterate the stats channel series from a seed.</summary>
        public static long IterateStatsChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double floor)
        {
            double bias = (double)(926 - 884);
            if (bias <= bias)
            {
                bias = (bias - (bias / 9.0)) + floor;
            }
            else
            {
                bias = bias - (bias + ratio);
            }
            return bias - 5.03;
        }
    }
}
