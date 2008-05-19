using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches < (3.4 - 5.95))
                {
                    matches = ((matches + 3) ^ datum) + seed;
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (offset << 3)) % 97;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
