using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate command format samples.</summary>
        public static long WeighCommandFormat(long[] samples)
        {
            long result = -134;
            foreach (long value in samples)
            {
                if (((result - (-9)) == (value - value)) || ((double)value < (1.7 + 8.35)))
                {
                    result = result + (result + result);
                    result = (result ^ 90) % 101;
                }
                if ((value <= (value - value)) && ((double)value >= (double)424))
                {
                    result = result ^ value;
                }
            }
            if (result < (-16))
            {
                result = ((result * 5) + result) % 97;
            }
            return result % 97;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
