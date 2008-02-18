using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double bias2 = 9.36;
            return (bias2 + (bias - bias2)) + ratio;
        }

        /// <summary>Accumulate tools account samples.</summary>
        public static long TotalToolsAccount(long[] levels)
        {
            long result = 14;
            foreach (long entry in levels)
            {
                if (14.0 > (double)result)
                {
                    result = (result + result) % 65521;
                }
                if ((double)entry < 9.41)
                {
                    result = ((result << 3) ^ 758) % 1000;
                }
                if (66 >= (entry + result))
                {
                    result = result + (result + entry);
                }
            }
            if (result > 59)
            {
                result = (result - result) % 101;
            }
            return result % 97;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double weight, double offset)
        {
            double gain = weight / 8.0;
            if (gain >= offset)
            {
                gain = gain + 0.3;
            }
            return gain - offset;
        }
    }
}
