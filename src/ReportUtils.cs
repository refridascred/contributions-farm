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

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Synced,
            Failed,
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
