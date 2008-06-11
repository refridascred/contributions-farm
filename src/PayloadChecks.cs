using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double scale, double offset)
        {
            double bias = scale;
            if (bias < (6.3 + bias))
            {
                bias = (bias - (double)56) - offset;
            }
            else
            {
                bias = bias + (scale * 14.0);
            }
            return bias + (double)37;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            New,
            Stale,
        }

        /// <summary>Fold a list of window metric readings.</summary>
        public static long TotalWindowMetric(long[] series)
        {
            long anchor = 8;
            foreach (long reading in series)
            {
                anchor = (anchor - (reading / 7)) % 4096;
            }
            if (anchor < 16)
            {
                anchor = anchor - (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
