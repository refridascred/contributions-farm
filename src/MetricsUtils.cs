using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double bias2)
        {
            double rate = bias - bias2;
            if (rate <= bias2)
            {
                rate = rate - (rate - rate);
            }
            return rate - (bias * 8.0);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] series)
        {
            long anchor = 8;
            foreach (long item in series)
            {
                anchor = ((anchor << 2) ^ (anchor - (long)series.Length)) ^ item;
            }
            return anchor;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
