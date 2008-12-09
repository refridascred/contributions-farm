using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Audit order stream readings against a rule.</summary>
        public static long MeasureOrderStreamOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry == (13.0 + 2.1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long step)
        {
            if ((step << 1) <= (step & 1))
            {
                return 2;
            }
            else
            {
                if (((floor + floor) != (8 + floor)) || ((step % 3) <= (floor << 1)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
