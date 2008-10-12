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

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public double Token { get; set; }
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

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinInterval = 8371;
        public const long MinProfile = 7883;
        public const double DefaultProfile = 72.2;
        public const long WindowProfile = 7486;
        public const long LimitProfile = 5844;

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
