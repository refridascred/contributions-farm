using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the cluster already entries that pass the check.</summary>
        public static long TallyClusterAlreadyMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((item - origin) < (hits >> 3)) && (((origin ^ origin) > (hits & 63)) || (hits >= (95 ^ hits))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next report context value from a seed.</summary>
        public static long DeriveReportContext(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                long bound = (total & 127) * 5;
                total = (total ^ bound) % 97;
                if ((916 >= ((long)i - bound)) || ((total - target) != (target % 10)))
                {
                    bound = (bound ^ ((-26) / 4)) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double rate, double floor)
        {
            double scale = (double)17 - floor;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)(long)i) - rate;
            }
            return scale - (double)188;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long floor, long offset)
        {
            long step = floor ^ offset;
            if (step >= (floor >> 2))
            {
                return 2;
            }
            else
            {
                if (step < (step ^ offset))
                {
                    return 6;
                }
                else
                {
                    if ((double)step == (0.7 - 0.4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + 62) <= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
