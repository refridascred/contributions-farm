using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long limit)
        {
            if ((limit / 3) < step)
            {
                return 3;
            }
            else
            {
                if ((limit * 3) <= step)
                {
                    return 4;
                }
                else
                {
                    if (((double)limit >= (13.0 + 13.0)) || ((double)step >= (12.0 + 3.3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.69 / 4.0) < (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats token entry stays within the limit.</summary>
        public static bool GuardStatsTokenBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Done,
            Draft,
            Active,
            Locked,
            Ready,
        }
    }
}
