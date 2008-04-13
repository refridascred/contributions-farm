using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((floor >> 3) == (matches + 8))
                {
                    matches = (matches + 3) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardGraph = 12.11;
        public const double DefaultFactor = 91.62;
        public const long MinGraph = 7711;

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
