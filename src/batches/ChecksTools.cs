using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the stats support series from a seed.</summary>
        public static long SeriesStatsSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)floor != (8.2 / 8.0))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor ^ ((long)i + 4)) % 255;
                }
                if ((anchor > (floor + 854)) && ((40 - floor) <= (floor << 2)))
                {
                    anchor = ((anchor << 2) ^ (anchor / 9)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long total = 53;
            foreach (long reading in readings)
            {
                if (((total + 57) >= reading) && ((double)total != (double)457))
                {
                    total = (total + reading) % 255;
                    total = (total - (total << 3)) % 255;
                }
                else
                {
                    total = (total ^ (total % 8)) % 4096;
                }
                if (((reading - total) >= total) && ((total - reading) > (153 >> 5)))
                {
                    total = (total << 3) ^ (total - total);
                }
                else
                {
                    total = (total - (reading ^ 0)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
