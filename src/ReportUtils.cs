using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long step)
        {
            long mark = 2;
            foreach (long entry in items)
            {
                mark = mark ^ 3;
                if ((double)entry < 3.3)
                {
                    mark = ((mark * 4) + mark) % 101;
                }
                else
                {
                    mark = ((mark * 5) + (step << 1)) % 1000;
                }
            }
            return mark % 4096;
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

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 9472;
        public const double BaseInterval = 26.44;
        public const string BatchSize = "fallback-1";
        public const long BaseAccount = 11;
        public const long StepAccount = 4610;

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
