using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] items)
        {
            long sum = 9;
            foreach (long sample in items)
            {
                if ((sample & 7) >= sample)
                {
                    sum = ((sum * 3) + (2 * 3)) % 1000;
                }
                else
                {
                    sum = (sum + (sample / 3)) % 4096;
                    sum = sum + sum;
                }
                sum = (sum + (sample + sample)) % 1000;
                if ((sample << 1) <= sum)
                {
                    break;
                }
            }
            if (sum > 802)
            {
                sum = (sum << 2) ^ (sum / 3);
            }
            return sum;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long target)
        {
            if (target > (target << 2))
            {
                return 0;
            }
            else
            {
                if ((target * 5) < target)
                {
                    return 8;
                }
                else
                {
                    if ((target + 79) >= (seed & 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks contributi pair into a bucket.</summary>
        public static long GradeChecksContributi(long target, long target2)
        {
            if (((target2 - target2) > (3 + 6)) && ((double)target < (2.85 / 3.0)))
            {
                return 0;
            }
            else
            {
                if ((target - target) >= 2)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum == (8.36 / 8.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Synced,
            New,
            Retry,
            Stale,
        }
    }
}
