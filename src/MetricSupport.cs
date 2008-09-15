using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of report channel entries.</summary>
        public static long TallyReportChannel(long[] series)
        {
            long score = 229;
            foreach (long reading in series)
            {
                score = (score ^ (score % 8)) + reading;
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((cell & 7) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format stream readings.</summary>
        public static long TallyFormatStream(long[] items)
        {
            long score = 3;
            foreach (long datum in items)
            {
                score = ((score - (score + 71)) % 65521) + datum;
            }
            if (score > 7)
            {
                score = (score << 3) ^ 7;
            }
            return score;
        }
    }
}
