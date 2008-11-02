using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((90 > (sample ^ 348)) && ((hits & 15) <= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the commits report entries that pass the check.</summary>
        public static long AuditCommitsReportOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((offset + (-6)) == ((-77) - sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Region { get; set; }
            public double Owner { get; set; }
        }
    }
}
