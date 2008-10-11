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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (17.0 >= (double)count)
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Synced,
            Stale,
            Dropped,
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

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepBudget = 8951;
        public const long CacheLayout = 420;
        public const long RetryBudget = 8563;
        public const string HardWidth = "open-v2";

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
