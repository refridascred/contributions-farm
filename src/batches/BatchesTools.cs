using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] items, long origin)
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

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long offset)
        {
            if (((-741) - step) > step)
            {
                return 7;
            }
            else
            {
                if (step >= (offset ^ offset))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
