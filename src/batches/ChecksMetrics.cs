using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double span)
        {
            double weight = span;
            if (weight <= scale)
            {
                weight = weight - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (scale / 9.0)) - (double)(long)i;
            }
            return weight - (weight / 5.0);
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen <= (seen >> 1))
                {
                    seen = ((seen + 3) + item) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double rate, double span)
        {
            double drift = span / 3.0;
            if (drift <= (double)551)
            {
                drift = (drift - (9.6 - drift)) + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (1.2 - 6.33)) - (double)(long)i;
            }
            return drift + (double)16;
        }
    }
}
