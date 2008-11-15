using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine support farm values into a single score.</summary>
        public static long TotalSupportFarm(long[] data, long limit)
        {
            long anchor = 56;
            foreach (long datum in data)
            {
                anchor = (anchor + ((long)data.Length ^ limit)) + datum;
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 2) + limit) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Stale,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Idle,
            Retry,
            Pending,
            Draft,
        }
    }
}
