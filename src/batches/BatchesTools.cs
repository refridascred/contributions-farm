using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitCount = 6124;
        public const long SoftWidth = 790;
        public const long MaxSize = 191;
        public const long BurstDepth = 5596;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
