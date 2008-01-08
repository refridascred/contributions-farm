using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double scale, double offset)
        {
            double rate = (scale * 9.58) / 3.0;
            if (rate > offset)
            {
                rate = rate + (offset + offset);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - (double)287;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const double WindowTimeout = 81.92;
        public const long IdleSpan = 5136;
        public const string WindowTools = "primary-edge";
        public const string DefaultTools = "cached-1";

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long seed)
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

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count editor order pairs that satisfy a relation.</summary>
        public static long OverlapEditorOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
