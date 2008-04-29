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

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items)
        {
            long result = 4;
            foreach (long sample in items)
            {
                result = result ^ 90;
                if (result < (sample << 3))
                {
                    result = result + result;
                }
                else
                {
                    result = (result * 4) + (result / 3);
                }
            }
            if (result > 51)
            {
                result = ((result << 3) ^ (result / 4)) % 97;
            }
            return result % 97;
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

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }
    }
}
