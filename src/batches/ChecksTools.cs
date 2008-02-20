using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first editor batch entry that matches the target.</summary>
        public static long FindEditorBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 25.33;
        public const long WindowContributi = 7457;
        public const long RetrySpan = 6261;
        public const string IdleContributi = "standard-edge";
        public const long MaxContributi = 9126;

        /// <summary>Measure how many window report samples are out of range.</summary>
        public static long CountWindowReportMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally - 693) == (tally - value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits << 2) > (datum >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
