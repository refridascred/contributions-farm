using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats graph entries that pass the check.</summary>
        public static long MeasureStatsGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally + value) == (value / 5)) && (((0.3 * 8.0) >= (double)(long)series.Length) || ((82 + value) < (long)series.Length)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Locked,
            Closed,
            Done,
        }

        /// <summary>Count the editor schema entries that pass the check.</summary>
        public static long MeasureEditorSchemaGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seed < (long)samples.Length)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
