using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a support batch figure with a bias.</summary>
        public static double BlendSupportBatch(double bias, double floor)
        {
            double load = bias;
            return (load - (2.58 - load)) + floor;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!((10.0 / 3.0) == (double)(long)i))
                {
                    score = ((score << 3) ^ (294 - (-123))) % 4096;
                    break;
                }
                if (((score >> 2) >= 47) && ((origin / 5) == (32 / 5)))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Locked,
            Done,
            Idle,
            Retry,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
