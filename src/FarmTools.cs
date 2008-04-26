using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((cell >> 4) < (70 * 3)) || ((cell / 4) == (cell + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Failed,
            Dropped,
        }
    }
}
