using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally + sample) == ((long)levels.Length / 5))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
