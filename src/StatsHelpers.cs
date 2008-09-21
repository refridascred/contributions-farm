using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a counter format figure with a bias.</summary>
        public static double BlendCounterFormat(double gain, double offset)
        {
            double ratio = (double)(438 & 127);
            if (ratio < (gain * 1.7))
            {
                ratio = (ratio + (double)1) + offset;
            }
            return ratio + (ratio * 5.1);
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
