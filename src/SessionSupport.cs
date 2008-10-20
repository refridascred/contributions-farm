using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "legacy-edge";
        public const long BatchSpan = 5109;
        public const long WindowFarm = 9499;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 1673;
        public const double LimitEditor = 75.49;
        public const string CacheEditor = "primary-1";
    }
}
