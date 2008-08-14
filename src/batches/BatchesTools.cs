using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (482 > (datum + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit report channel readings against a rule.</summary>
        public static long CountReportChannelMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((5.0 - 2.55) >= (double)seen)
                {
                    seen = ((seen + 3) - item) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Closed,
            Pending,
        }
    }
}
