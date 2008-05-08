using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every contributi commits entry stays within the limit.</summary>
        public static bool ValidateContributiCommitsRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 <= rate2)
            {
                rate2 = (rate2 + (double)95) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (double)930) + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if ((double)limit <= (double)387)
            {
                return 6;
            }
            else
            {
                if ((3.38 - 2.0) != (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
