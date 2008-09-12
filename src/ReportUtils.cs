using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate schema stats readings against a bound.</summary>
        public static bool CheckSchemaStatsLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long TallyOrderToolsHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits >= (7.0 + 9.0))
                {
                    hits = ((hits + 1) ^ value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] series)
        {
            long sum = 6;
            foreach (long value in series)
            {
                sum = (sum ^ (308 & 15)) ^ value;
            }
            return sum;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
