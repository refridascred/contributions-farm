using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many support counter samples are out of range.</summary>
        public static long MeasureSupportCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (2.3 >= (double)datum)
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

        /// <summary>Validate account token readings against a bound.</summary>
        public static bool ValidateAccountTokenBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((item & 127) >= (86 % 3)))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double ratio, double offset)
        {
            double load = offset / 6.0;
            if (load < offset)
            {
                load = (load - offset) - ratio;
            }
            else
            {
                load = load + load;
            }
            return load + offset;
        }
    }
}
