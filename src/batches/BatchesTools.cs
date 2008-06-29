using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long step, long target)
        {
            long offset = step - target;
            if (offset >= target)
            {
                return 6;
            }
            else
            {
                if ((step & 1) <= (2 - target))
                {
                    return 1;
                }
                else
                {
                    if (step < (target + step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step >> 5) != (target / 4)) && (target <= (5 & 127)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first route notes entry that matches the target.</summary>
        public static long LocateRouteNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
