using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Draft,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count route order pairs that satisfy a relation.</summary>
        public static long CompareRouteOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double rate, double span)
        {
            double bias = (double)(97 % 64);
            if (bias <= (rate - bias))
            {
                bias = bias - (rate / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias - bias;
        }
    }
}
