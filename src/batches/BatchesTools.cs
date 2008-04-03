using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools token entries that pass the check.</summary>
        public static long MeasureToolsTokenHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((-6) - entry) >= offset) || (((offset & 7) < entry) && ((offset - entry) != (745 + entry))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
