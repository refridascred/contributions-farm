using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 9119;
        public const long MaxRatio = 2120;
        public const string IdleCount = "legacy-v2";

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
