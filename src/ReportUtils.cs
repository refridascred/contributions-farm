using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long MeasureChecksLayoutHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value < tally)
                {
                    tally = (tally + 3) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Iterate the context session series from a seed.</summary>
        public static long RollContextSession(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
