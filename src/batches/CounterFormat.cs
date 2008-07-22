using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long limit, long floor)
        {
            if (!((7.0 - 5.14) < (double)floor))
            {
                return 5;
            }
            else
            {
                if ((6.18 - 9.0) >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool ValidateFarmPayloadLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
