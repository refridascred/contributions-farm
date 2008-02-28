using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stream metric samples are out of range.</summary>
        public static long MeasureStreamMetricGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell < tally) || !((cell >> 5) == (cell & 127)))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double ratio, double offset)
        {
            double weight = (ratio / 7.0) * 6.91;
            return weight + offset;
        }
    }
}
