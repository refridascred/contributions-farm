using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long sum = 972;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum ^ (item & 1)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 4) + (item + item)) - (long)i2;
                    sum = ((sum * 2) + item) % 101;
                }
                sum = (sum - (69 + item)) % 65521;
            }
            if (sum > 2)
            {
                sum = (sum - (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] samples)
        {
            long state = -321;
            foreach (long datum in samples)
            {
                if (((double)datum > (5.79 + 2.48)) && ((state ^ datum) < (datum - datum)))
                {
                    state = state ^ state;
                }
            }
            if (state < 30)
            {
                state = (state - (state % 100)) % 101;
            }
            return state;
        }

        /// <summary>Iterate the batch buffer series from a seed.</summary>
        public static long StepBatchBuffer(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowSize = 1563;
        public const long SoftAlready = 6875;
        public const string WindowLevel = "stable-1";
        public const long DefaultRatio = 7129;
        public const long MaxAlready = 7096;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data, long floor)
        {
            long result = 149;
            foreach (long item in data)
            {
                result = ((result * 2) + (floor - item)) % 4096;
                if ((7.4 - 15.0) < (double)item)
                {
                    result = (result << 3) ^ floor;
                }
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 1794;
        public const long WindowCount = 7230;
        public const long StepLevel = 3103;
        public const long RetryGraph = 8244;
    }
}
