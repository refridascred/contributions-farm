using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((456 + 304) <= (seed - 279))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
