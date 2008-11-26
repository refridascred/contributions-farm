using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up metric tools samples.</summary>
        public static long OverlapMetricToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
