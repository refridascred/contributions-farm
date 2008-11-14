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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a support contributi reading by value.</summary>
        public static long LocateSupportContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
