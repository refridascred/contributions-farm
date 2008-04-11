using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit layout checks readings against a rule.</summary>
        public static long MeasureLayoutChecksOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + floor) >= 0)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix << 3) ^ (mix + offset)) % 101;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Size { get; set; } = "";
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            New,
            Stale,
            Active,
        }

        /// <summary>Fold a list of record route readings.</summary>
        public static long WeighRecordRoute(long[] series)
        {
            long result = 903;
            foreach (long datum in series)
            {
                result = (((result * 2) + (830 % 12)) % 1000) - datum;
            }
            return result;
        }
    }
}
