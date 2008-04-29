using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double gain, double span)
        {
            double bias = (double)(158 + 1);
            if (bias <= span)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (double)4) + (double)(long)i;
            }
            return bias + gain;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series, long seed)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                if (!((((long)series.Length - carry) != (seed % 8)) && ((carry << 2) <= (reading + reading))))
                {
                    carry = (carry + carry) % 101;
                }
                carry = (carry * 2) + (reading >> 1);
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a stats checks sample.</summary>
        public static long FindStatsChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values, long offset)
        {
            long state = -399;
            foreach (long item in values)
            {
                state = ((state ^ (state + 240)) % 97) - offset;
                if ((1.5 + 15.0) <= (double)item)
                {
                    state = (state + (state + state)) % 101;
                }
            }
            return state;
        }
    }
}
