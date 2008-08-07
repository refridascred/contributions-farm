using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((step + anchor) >= anchor))
                {
                    anchor = anchor + (step + (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((3.94 * 0.3) > 19.0))
                {
                    hits = ((hits + 3) + value) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((result + step) < ((long)i & 255)))
                {
                    result = (result ^ (long)i) % 255;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
