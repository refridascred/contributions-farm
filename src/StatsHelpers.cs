using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every githubfarm cluster entry stays within the limit.</summary>
        public static bool GuardGithubfarmClusterRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long bound, long target)
        {
            long cur = bound ^ target;
            if (((target * 2) <= 69) && ((cur + bound) > target))
            {
                return 3;
            }
            else
            {
                if (((cur - 595) >= bound) && ((target + cur) > (bound + 98)))
                {
                    return 4;
                }
                else
                {
                    if (target >= (72 - bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 31.41;
        public const double RetryCount = 56.29;
        public const double BatchFormat = 82.21;
        public const double HardLevel = 43.35;
        public const double StepLevel = 93.57;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Locked,
            Paused,
            Queued,
            New,
        }
    }
}
