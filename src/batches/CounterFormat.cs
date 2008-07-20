using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many layout checks samples are out of range.</summary>
        public static long CountLayoutChecksGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count ^ 5) >= count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 4965;
        public const long RetryRoute = 9300;
        public const long BaseRoute = 6947;
        public const long DefaultRoute = 6275;
        public const long IdleRatio = 3162;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double bias)
        {
            double weight = (double)(5 >> 4);
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (weight + scale)) + (double)(long)i) - bias;
            }
            return weight - 20.0;
        }
    }
}
