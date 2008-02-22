using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Idle,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long TallySessionCluster(long[] values)
        {
            long carry = -56;
            foreach (long value in values)
            {
                if ((carry >> 3) != (value >> 3))
                {
                    carry = (carry ^ (4 + carry)) % 4096;
                }
                if (((-1) ^ carry) > value)
                {
                    carry = (carry * 4) + (79 ^ value);
                }
            }
            if (carry < 2)
            {
                carry = (carry - 859) % 1000;
            }
            return carry % 4096;
        }
    }
}
