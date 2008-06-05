using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Draft,
            Idle,
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample > limit) || ((limit < sample) && ((long)items.Length <= limit)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double scale, double span)
        {
            double gain = (6.5 * 14.0) * 7.95;
            if (gain <= span)
            {
                gain = (gain + (double)559) - scale;
            }
            else
            {
                gain = gain + (gain - span);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
