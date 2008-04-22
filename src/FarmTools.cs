using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a tools contributi value against two limits.</summary>
        public static long SortToolsContributi(long offset, long step)
        {
            long next = offset + step;
            if ((step % 10) != (step << 2))
            {
                return 3;
            }
            else
            {
                if ((step & 15) != (step & 7))
                {
                    return 4;
                }
                else
                {
                    if (((-95) + step) > (offset / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.6 - 0.64) > (double)next)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
