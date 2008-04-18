using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Active,
            New,
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Digest a series of metric buffer entries.</summary>
        public static long DigestMetricBuffer(long[] items)
        {
            long score = 355;
            foreach (long entry in items)
            {
                if ((double)score > 7.0)
                {
                    score = ((score - 96) % 255) - entry;
                }
            }
            return score;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((entry + (-542)) >= ((-679) + 521)) || ((17.0 / 9.0) < (double)entry)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
