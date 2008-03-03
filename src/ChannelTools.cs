using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (step < hits)
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((19 - matches) >= 268) && ((1.0 + 5.6) != (double)datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
