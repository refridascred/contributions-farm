using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] items, long limit)
        {
            long mix = 17;
            foreach (long entry in items)
            {
                if (((double)entry < (1.4 * 1.26)) && (entry < (mix + mix)))
                {
                    mix = ((mix + (entry ^ mix)) % 1000) + limit;
                }
            }
            return mix;
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
