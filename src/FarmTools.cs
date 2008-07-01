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

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally & 127) <= (item & 255))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
