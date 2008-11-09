using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double rate = (double)(54 - 80);
            if (rate <= ratio)
            {
                rate = (rate + (rate - rate)) + offset;
            }
            return rate + (double)37;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series, long seed)
        {
            long result = 3;
            foreach (long value in series)
            {
                result = ((result - (8 + seed)) % 1000) - value;
            }
            return result % 1000;
        }
    }
}
