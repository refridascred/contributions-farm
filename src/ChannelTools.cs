using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit channel counter readings against a rule.</summary>
        public static long AuditChannelCounterHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item > (6.0 / 4.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            New,
            Queued,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)sample != (double)357)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }
    }
}
