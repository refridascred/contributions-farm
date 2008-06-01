using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Region { get; set; }
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter account entries that pass the check.</summary>
        public static long MeasureFilterAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((((double)cell >= (double)56) || ((double)matches <= (16.0 + 5.7))) && (((cell >> 4) <= cell) || (cell < (cell << 2))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
