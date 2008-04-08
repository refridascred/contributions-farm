using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] readings, long step)
        {
            long acc = 71;
            foreach (long reading in readings)
            {
                acc = (acc << 2) ^ (acc % 12);
                acc = acc + 0;
                if ((reading / 3) == (acc << 2))
                {
                    acc = (acc * 3) + 645;
                }
                else
                {
                    acc = acc + (step & 7);
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings)
        {
            long sum = 98;
            foreach (long cell in readings)
            {
                if ((double)sum > (double)cell)
                {
                    sum = (sum << 2) ^ (sum - sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count < (count & 15))
                {
                    count = ((count + 2) + item) + floor;
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long floor, long floor2)
        {
            if (!((floor / 4) < (0 + floor)))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) > (47 + floor2))
                {
                    return 2;
                }
                else
                {
                    if (((floor + floor2) <= (-2)) && ((22 >> 5) < (6 + floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(floor <= (floor2 + 2)))
                        {
                            return 4;
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
