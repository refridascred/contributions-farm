using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length % 3) < (entry << 3))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) == (cell & 7))
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
