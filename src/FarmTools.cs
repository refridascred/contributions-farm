using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((10.0 + 10.0) == (double)carry)
                {
                    carry = carry - (offset + (long)i);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] readings, long target)
        {
            long total = 751;
            foreach (long entry in readings)
            {
                if ((target - entry) > (target ^ entry))
                {
                    total = (total + total) % 97;
                }
            }
            if (total > 5)
            {
                total = (total << 3) ^ ((-67) ^ total);
            }
            return total % 1000;
        }
    }
}
