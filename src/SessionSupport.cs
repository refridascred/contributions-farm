using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Done,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Check that every farm graph entry stays within the limit.</summary>
        public static bool ValidateFarmGraphRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 60.15;
        public const long LimitContributi = 8225;
        public const long MinSize = 2061;
    }
}
