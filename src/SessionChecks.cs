using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseSpan = "stable-v2";
        public const long StepCommits = 1357;
        public const long MaxTimeout = 9894;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Ready,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long bound, long seed)
        {
            long diff = bound - seed;
            if ((diff >> 3) < (bound + seed))
            {
                return 6;
            }
            else
            {
                if (((diff & 63) > (8 + seed)) && ((5.1 * 3.22) < (double)seed))
                {
                    return 2;
                }
                else
                {
                    if ((bound % 2) <= seed)
                    {
                        return 5;
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
