using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long step, long step2)
        {
            if ((0 >> 3) != (step2 % 16))
            {
                return 1;
            }
            else
            {
                if (!(68 > step))
                {
                    return 0;
                }
                else
                {
                    if (!((step % 7) <= (step2 - 0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step2 >> 1) > (step & 127))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate format support readings against a bound.</summary>
        public static bool ValidateFormatSupportRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Ready,
            Pending,
            Draft,
        }
    }
}
