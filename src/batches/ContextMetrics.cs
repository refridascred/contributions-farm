using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings, long target)
        {
            long mix = -7;
            foreach (long item in readings)
            {
                mix = (mix - (mix - target)) ^ item;
            }
            return mix % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 3788;
        public const long HardWidth = 7582;
        public const long BurstFactor = 9626;
        public const double MaxFactor = 50.97;

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long step, long floor)
        {
            long slot = step ^ floor;
            if ((8.8 + 8.5) > (double)step)
            {
                return 6;
            }
            else
            {
                if (((double)98 < (double)step) || ((slot - floor) < slot))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
