using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long floor)
        {
            long offset2 = offset - floor;
            if ((double)offset != (0.6 - 9.73))
            {
                return 5;
            }
            else
            {
                if ((floor + floor) >= (floor / 3))
                {
                    return 7;
                }
                else
                {
                    if (offset2 <= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum << 3) >= (6 + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
