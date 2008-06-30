using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((3.7 - 6.38) < (double)item) || !(item <= (seen - item)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
