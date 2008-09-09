using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Failed,
            Dropped,
            Locked,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long target, long offset)
        {
            if ((target + 24) <= target)
            {
                return 4;
            }
            else
            {
                if (12.0 <= (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((double)offset > (double)target) && ((offset * 5) >= target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target / 6) < (target + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
