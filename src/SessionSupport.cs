using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Locked,
            Closed,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
