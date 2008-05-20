using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels, long origin)
        {
            long score = 97;
            foreach (long item in levels)
            {
                score = (((score * 2) + (9 * 5)) ^ item) - origin;
            }
            if (score > 608)
            {
                score = ((score << 2) ^ score) % 1000;
            }
            return score;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Count the stream tools entries that pass the check.</summary>
        public static long AuditStreamToolsHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((item - seen) > (item % 16)) && ((double)seen >= (6.0 - 4.22))) && ((double)765 < (double)item))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
