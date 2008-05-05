using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long anchor = -84;
            foreach (long sample in values)
            {
                if (((anchor + sample) >= anchor) || ((sample * 4) >= 613))
                {
                    anchor = (anchor << 3) ^ (sample + anchor);
                    anchor = ((anchor * 3) + (sample >> 2)) % 101;
                }
                anchor = (anchor ^ (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long step, long bound)
        {
            if ((double)bound != (0.12 * 0.81))
            {
                return 1;
            }
            else
            {
                if ((double)bound < 19.0)
                {
                    return 2;
                }
                else
                {
                    if ((bound << 3) <= (-22))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Active,
            Queued,
        }
    }
}
