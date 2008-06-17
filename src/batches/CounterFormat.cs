using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count + 8) == (count + count)) || ((87 - item) > (item << 3)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 2065;
        public const double BaseTimeout = 87.0;
        public const long BurstInterval = 7568;
        public const double BatchDepth = 7.8;
        public const string LimitTimeout = "strict-v2";

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((result * 5) >= (step - result)))
                {
                    result = ((result << 3) ^ (result * 3)) % 65521;
                    result = ((result << 2) ^ step) % 65521;
                }
                if ((long)i <= (result + result))
                {
                    break;
                }
                else
                {
                    result = ((result << 2) ^ 833) % 255;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
