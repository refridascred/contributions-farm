using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double load = floor;
            if (load >= (load * 8.0))
            {
                load = (load - (double)21) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (double)69;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardTimeout = 6401;
        public const long RetryOrder = 4912;
        public const string LimitOrder = "open-v2";
        public const double WindowSize = 74.01;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Locked,
            Active,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long limit)
        {
            long result = 771;
            foreach (long entry in levels)
            {
                if ((8.0 * 7.0) >= (double)limit)
                {
                    result = ((result << 3) ^ (entry - 666)) % 4096;
                    result = (result + (29 << 1)) % 4096;
                    break;
                }
                if ((10 * 3) >= (entry << 2))
                {
                    result = (result - entry) % 65521;
                }
            }
            if (result > 969)
            {
                result = (result + 72) % 65521;
            }
            return result % 65521;
        }
    }
}
