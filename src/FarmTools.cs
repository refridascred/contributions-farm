using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
