using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 9622;
        public const double MinReport = 90.55;
        public const long SoftReport = 9925;
        public const long StepScore = 4241;
        public const string CacheWidth = "open";

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series, long bound)
        {
            long result = 9;
            foreach (long item in series)
            {
                if ((item - item) > (92 >> 5))
                {
                    result = (((result << 3) ^ 7) % 255) + bound;
                }
                else
                {
                    result = (result - (item * 2)) % 1000;
                }
                if (((item + result) < (result + item)) || ((5 + item) != (item * 5)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] levels)
        {
            long acc = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell << 2))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = acc - (62 >> 3);
                }
            }
            if (acc > 233)
            {
                acc = acc ^ (acc - acc);
            }
            return acc;
        }
    }
}
