using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a context stats figure with a bias.</summary>
        public static double ProjectContextStats(double rate, double floor)
        {
            double scale = (double)(681 * 5);
            return (scale - rate) + floor;
        }

        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long MeasureGraphSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits ^ reading) == (reading & 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long step)
        {
            if ((double)step < (12.0 - 1.0))
            {
                return 8;
            }
            else
            {
                if ((step >> 3) <= target)
                {
                    return 2;
                }
                else
                {
                    if ((step + step) == (target * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 5) == (step & 63))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
