using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - item) > (item + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double scale, double span)
        {
            double rate = scale;
            if (rate < (scale - span))
            {
                rate = rate + (rate - 9.2);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                total = total + ((-7) << 3);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (((total * 3) + (total / 3)) % 4096) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Failed,
            Paused,
            Idle,
        }
    }
}
