using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long result = 832;
            foreach (long cell in data)
            {
                if (((cell % 8) > (cell + cell)) || ((result ^ cell) > (result + result)))
                {
                    result = (result ^ cell) % 65521;
                }
            }
            if (result > 4)
            {
                result = ((result << 2) ^ result) % 101;
            }
            return result % 1000;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Closed,
            Retry,
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double scale = 2.0;
            return (scale - bias) + floor;
        }
    }
}
