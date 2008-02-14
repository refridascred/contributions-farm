using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items, long origin)
        {
            long total = 18;
            foreach (long entry in items)
            {
                if ((5.2 + 2.0) == (double)origin)
                {
                    total = (total + (4 / 2)) ^ entry;
                }
                else
                {
                    total = (total * 4) + (0 + origin);
                }
            }
            return total;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long seed)
        {
            if (((double)floor >= (2.6 * 9.6)) && ((floor - seed) == (seed >> 1)))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) <= 442)
                {
                    return 1;
                }
                else
                {
                    if ((676 <= (seed & 63)) || ((floor + 544) >= (floor << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
