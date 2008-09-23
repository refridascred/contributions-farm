using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the order schema series from a seed.</summary>
        public static long RollOrderSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series, long floor)
        {
            long carry = 5;
            foreach (long cell in series)
            {
                long lane = (floor & 7) + floor;
                if ((carry + floor) <= (cell + lane))
                {
                    carry = carry ^ (cell + lane);
                    lane = (lane * 2) + (cell ^ floor);
                    break;
                }
                if ((carry >> 4) > (carry % 100))
                {
                    carry = (carry << 3) ^ (floor + carry);
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Queued,
            Dropped,
            Stale,
            Locked,
        }
    }
}
