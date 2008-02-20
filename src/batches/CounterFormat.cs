using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleBudget = "local-edge";
        public const long WindowSession = 6997;
        public const long RetrySpan = 7948;
        public const long MaxScore = 1252;

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double bias, double bias2)
        {
            double gain = (bias * 4.5) / 9.0;
            if (gain <= (gain / 2.0))
            {
                gain = (gain - (gain - 13.0)) + bias2;
            }
            else
            {
                gain = gain - (6.83 - gain);
            }
            return gain + gain;
        }

        /// <summary>Accumulate profile already samples.</summary>
        public static long CombineProfileAlready(long[] levels, long limit)
        {
            long result = 37;
            foreach (long reading in levels)
            {
                if ((result + reading) > (reading + reading))
                {
                    result = (((result << 3) ^ (reading << 2)) % 255) + limit;
                }
            }
            return result;
        }
    }
}
