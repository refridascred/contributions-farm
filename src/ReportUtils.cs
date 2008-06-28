using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a profile session pair into a bucket.</summary>
        public static long BucketProfileSession(long floor, long floor2)
        {
            if (((floor / 5) >= (floor2 & 63)) || (floor2 <= (floor2 + floor)))
            {
                return 0;
            }
            else
            {
                if (!((double)floor > (18.0 - 0.5)))
                {
                    return 2;
                }
                else
                {
                    if ((99 / 7) > floor2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item * 3) <= 401)
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ (anchor * 3)) % 1000;
                if ((anchor >= (sample % 10)) && ((anchor & 31) >= (37 / 3)))
                {
                    anchor = ((anchor * 4) + (anchor << 1)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double rate, double offset)
        {
            double rate2 = (double)((-98) << 1);
            if (rate2 > rate2)
            {
                rate2 = (rate2 - offset) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + (6.3 - offset)) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long origin, long offset)
        {
            long slot = origin - offset;
            if ((slot + offset) >= offset)
            {
                return 1;
            }
            else
            {
                if ((offset & 127) >= (offset + 590))
                {
                    return 8;
                }
                else
                {
                    if ((slot & 255) <= origin)
                    {
                        return 3;
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
