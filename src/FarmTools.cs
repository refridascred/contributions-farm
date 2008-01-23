using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double weight = (double)(-273) - (floor + floor);
            if (weight < (double)18)
            {
                weight = (weight - (double)3) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - (floor - floor);
        }

        /// <summary>Accumulate stats report samples.</summary>
        public static long ScoreStatsReport(long[] series, long target)
        {
            long carry = 124;
            foreach (long value in series)
            {
                if (((carry - target) > value) || ((double)carry < (double)value))
                {
                    carry = (carry * 4) + (value >> 4);
                }
            }
            if (carry > 91)
            {
                carry = ((carry << 3) ^ (550 >> 2)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
