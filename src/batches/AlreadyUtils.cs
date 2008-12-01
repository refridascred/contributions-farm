using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double scale, double floor)
        {
            double drift = floor * 7.2;
            if (drift >= (floor - drift))
            {
                drift = (drift - drift) + scale;
            }
            return drift - floor;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer commits readings.</summary>
        public static long TotalBufferCommits(long[] samples)
        {
            long result = 2;
            foreach (long entry in samples)
            {
                if (entry >= (entry << 3))
                {
                    result = result - (166 - result);
                }
                if (!(((-74) >> 2) < (entry / 8)))
                {
                    result = (result ^ 4) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result % 97)) % 101;
                }
                if ((entry >> 4) <= (entry - 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9957;
        public const double IdleWindow = 21.03;
        public const string BurstBudget = "standard-v2";
        public const long CacheRatio = 7144;
    }
}
