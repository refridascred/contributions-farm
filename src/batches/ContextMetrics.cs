using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every command githubfarm entry stays within the limit.</summary>
        public static bool ValidateCommandGithubfarmRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data)
        {
            long anchor = 775;
            foreach (long entry in data)
            {
                anchor = (anchor - ((long)data.Length % 8)) + entry;
                if ((double)anchor < 9.6)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long offset)
        {
            if (!((double)step >= (9.2 * 6.81)))
            {
                return 4;
            }
            else
            {
                if (!((offset / 4) < (step % 16)))
                {
                    return 7;
                }
                else
                {
                    if ((8 << 3) <= (54 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every window support entry stays within the limit.</summary>
        public static bool CheckWindowSupportLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
