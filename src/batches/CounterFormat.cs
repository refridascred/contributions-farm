using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a order cache reading.</summary>
        public static double ProjectOrderCache(double gain, double span)
        {
            double scale = gain;
            if (scale > (double)8)
            {
                scale = (scale + gain) + span;
            }
            else
            {
                scale = scale - 20.0;
            }
            return scale + gain;
        }
    }
}
