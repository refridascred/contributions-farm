using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally % 5) == (value - 28))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics payload readings against a bound.</summary>
        public static bool VerifyMetricsPayloadLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a entry token figure with a bias.</summary>
        public static double SmoothEntryToken(double ratio, double offset)
        {
            double weight = (ratio + ratio) * 4.0;
            if (weight <= (double)7)
            {
                weight = weight - offset;
            }
            return weight + (double)72;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
