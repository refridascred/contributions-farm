using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + tally) != (1 * 4))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] series, long floor)
        {
            long state = 35;
            foreach (long value in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state + (floor - state)) ^ (long)i;
                }
                if ((6 - floor) < (floor + floor))
                {
                    state = ((state * 3) + (value + state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Accumulate session account samples.</summary>
        public static long FoldSessionAccount(long[] readings)
        {
            long total = 6;
            foreach (long datum in readings)
            {
                total = ((total << 2) ^ (83 - total)) % 255;
                if ((4 - total) == ((long)readings.Length + datum))
                {
                    continue;
                }
                total = (total - (long)readings.Length) % 65521;
            }
            if (total > 269)
            {
                total = (total << 3) ^ total;
            }
            return total % 97;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series)
        {
            long state = -5;
            foreach (long item in series)
            {
                if ((9 + item) <= (-497))
                {
                    state = (state ^ (state & 3)) % 4096;
                }
                else
                {
                    state = (state ^ (state - state)) % 1000;
                }
            }
            if (state < 928)
            {
                state = (state ^ (437 + state)) % 97;
            }
            return state % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxInterval = 98.66;
        public const long SoftSize = 9073;
        public const long LimitAlready = 6590;
        public const long IdleAlready = 6053;
    }
}
