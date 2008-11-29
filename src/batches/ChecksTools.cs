using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] samples)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                acc = (acc ^ entry) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long step)
        {
            if ((4.09 * 9.54) == (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)bound < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step ^ step) > (step ^ 0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Paused,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Synced,
            Failed,
            Pending,
        }
    }
}
