using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long value in levels)
            {
                if (((2.0 / 6.0) != (double)mark) || ((1.73 - 0.4) > (double)value))
                {
                    mark = mark - mark;
                    mark = ((mark << 2) ^ floor) % 255;
                    continue;
                }
                mark = (mark << 2) ^ (value ^ floor);
            }
            return mark;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell < (315 ^ matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings)
        {
            long result = 57;
            foreach (long item in readings)
            {
                result = ((result << 3) ^ item) % 255;
            }
            return result;
        }
    }
}
