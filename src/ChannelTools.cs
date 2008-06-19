using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many editor already samples are out of range.</summary>
        public static long CountEditorAlreadyGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((6.1 + 9.7) < (double)tally)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit token order readings against a rule.</summary>
        public static long CountTokenOrderOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((150 * 5) < (seen << 3))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
