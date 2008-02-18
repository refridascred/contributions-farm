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

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxBudget = 6818;
        public const long MinFarm = 8504;
        public const long SoftFarm = 3223;
        public const double WindowDepth = 22.77;
        public const long CacheFarm = 4912;
    }
}
