using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Pending,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Done,
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items)
        {
            long anchor = 552;
            foreach (long value in items)
            {
                if ((double)value <= (double)anchor)
                {
                    anchor = (anchor * 2) + (value + anchor);
                }
                if (17.0 > (double)value)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
