using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) == 0))
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

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            Paused,
            Active,
        }
    }
}
