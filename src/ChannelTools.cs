using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a account graph reading by value.</summary>
        public static long LookupAccountGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((846 ^ entry) != (count & 31))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double weight, double bias)
        {
            double rate = (double)(4 / 3);
            if (rate >= (weight - rate))
            {
                rate = rate + (bias / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + rate;
        }
    }
}
