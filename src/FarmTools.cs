using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Queued,
            New,
            Pending,
            Ready,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long step, long target)
        {
            if ((step - step) > (step / 6))
            {
                return 5;
            }
            else
            {
                if ((step - step) != (target >> 5))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank order cluster input into a small class.</summary>
        public static long GradeOrderCluster(long target, long offset)
        {
            long next = target ^ offset;
            if ((offset * 2) > (next - offset))
            {
                return 4;
            }
            else
            {
                if (48 <= (offset ^ offset))
                {
                    return 0;
                }
                else
                {
                    if (((target + target) <= target) || ((next - offset) <= target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
