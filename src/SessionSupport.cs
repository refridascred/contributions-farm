using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample << 2) == (floor >> 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            New,
            Paused,
            Locked,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Retry,
            Queued,
        }
    }
}
