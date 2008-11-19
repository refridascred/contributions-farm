using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((86 / 8) <= bound)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Active,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long bound, long floor)
        {
            long offset = bound + floor;
            if ((45 << 2) < floor)
            {
                return 6;
            }
            else
            {
                if (((floor / 2) >= (floor >> 3)) || ((floor * 2) == (79 + (-50))))
                {
                    return 0;
                }
                else
                {
                    if ((7 + bound) > floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound + offset) >= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values, long floor)
        {
            long mark = 77;
            foreach (long cell in values)
            {
                if (mark > (floor - (-886)))
                {
                    mark = mark ^ (floor - cell);
                }
            }
            if (mark < 724)
            {
                mark = mark - mark;
            }
            return mark % 97;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long sum = 96;
            foreach (long datum in items)
            {
                if (sum > (datum * 5))
                {
                    sum = (sum ^ (sum << 3)) % 1000;
                }
                if (!((sum & 31) <= sum))
                {
                    sum = ((sum << 3) ^ (719 / 6)) % 4096;
                }
                sum = (sum ^ (datum * 3)) % 4096;
            }
            if (sum > 26)
            {
                sum = ((sum << 2) ^ (38 % 7)) % 4096;
            }
            return sum;
        }
    }
}
