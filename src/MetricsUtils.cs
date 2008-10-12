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

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
