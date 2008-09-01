using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine commits order values into a single score.</summary>
        public static long CombineCommitsOrder(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                total = ((total ^ (long)levels.Length) % 65521) ^ reading;
            }
            if (total > (-662))
            {
                total = (total + total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double rate = (0.5 * 1.3) * 4.86;
            if (rate > 8.1)
            {
                rate = (rate + (9.54 * 3.1)) - scale;
            }
            else
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + 17.0) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((((5 ^ 85) < matches) || ((limit + matches) != (matches << 1))) && (cell <= (matches + limit)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 7332;
        public const long BurstSpan = 53;
        public const long DefaultLayout = 2630;
        public const long SoftLayout = 974;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
