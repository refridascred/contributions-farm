using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long target, long seed)
        {
            if (((-368) - seed) < (target >> 2))
            {
                return 8;
            }
            else
            {
                if ((target <= (target + seed)) && ((target ^ 398) <= (target - seed)))
                {
                    return 2;
                }
                else
                {
                    if (((target + seed) <= (seed + (-998))) || ((target + target) >= (seed * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed + seed) >= (258 & 31)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batch metric samples.</summary>
        public static long OverlapBatchMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
