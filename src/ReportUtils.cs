using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Queued,
            Idle,
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchScore = "strict-edge";
        public const long DefaultBatch = 9942;
        public const double MinRatio = 92.82;
        public const double HardBatch = 71.94;
        public const double LimitBudget = 30.13;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double offset)
        {
            double gain = offset;
            if (gain > (6.0 / 4.0))
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + (offset - scale);
            }
            return gain - offset;
        }
    }
}
