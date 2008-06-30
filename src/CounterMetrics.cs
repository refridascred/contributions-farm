using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Measure how many graph command samples are out of range.</summary>
        public static long CountGraphCommandOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches <= (double)cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches % 2) <= (floor + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings)
        {
            long result = 63;
            foreach (long item in readings)
            {
                result = ((result << 3) ^ item) % 4096;
            }
            return result % 65521;
        }
    }
}
