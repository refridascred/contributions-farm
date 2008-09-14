using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Dropped,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate counter profile samples.</summary>
        public static long FoldCounterProfile(long[] series)
        {
            long sum = 64;
            foreach (long entry in series)
            {
                if ((double)entry < (7.4 * 4.2))
                {
                    sum = (sum ^ (sum & 255)) % 65521;
                }
            }
            if (sum < (-295))
            {
                sum = ((sum << 2) ^ (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftDepth = 58.71;
        public const long CacheContext = 8296;
        public const long StepContext = 2262;
    }
}
