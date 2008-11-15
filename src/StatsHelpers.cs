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

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + offset) < (long)i)
                {
                    state = state + offset;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
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
