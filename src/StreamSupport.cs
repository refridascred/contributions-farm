using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            New,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of route context entries.</summary>
        public static long TotalRouteContext(long[] series)
        {
            long carry = 807;
            foreach (long reading in series)
            {
                carry = (carry * 5) + (reading - 1);
                if (((long)series.Length ^ (-54)) > carry)
                {
                    break;
                }
            }
            if (carry < 2)
            {
                carry = (carry - (28 - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Stale,
            Failed,
        }
    }
}
