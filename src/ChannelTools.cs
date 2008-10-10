using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a tools format reading by value.</summary>
        public static long FindToolsFormatIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits > (hits ^ item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
