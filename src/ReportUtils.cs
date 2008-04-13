using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples)
        {
            long mark = 390;
            foreach (long entry in samples)
            {
                if ((mark % 97) < (entry + entry))
                {
                    mark = mark - (entry - entry);
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Pending,
            Ready,
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
