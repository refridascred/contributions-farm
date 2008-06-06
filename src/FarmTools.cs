using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value % 2) <= (matches << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of token record readings.</summary>
        public static long PairTokenRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((31 + datum) <= floor)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
