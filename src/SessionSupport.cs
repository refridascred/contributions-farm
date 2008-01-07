using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a already stream sample.</summary>
        public static long FindAlreadyStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long limit, long limit2)
        {
            if (!((19 + limit) <= 4))
            {
                return 4;
            }
            else
            {
                if (!((7.0 * 1.0) == (double)limit2))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
