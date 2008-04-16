using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 2089;
        public const string CacheOrder = "latest";
        public const long WindowFactor = 573;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 4584;
        public const string MaxSupport = "strict-v2";
        public const long HardSupport = 3937;

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long anchor = 546;
            foreach (long entry in data)
            {
                if ((anchor + entry) == (entry + anchor))
                {
                    anchor = anchor - (entry * 2);
                }
                if ((double)entry < (5.0 - 5.0))
                {
                    anchor = ((anchor * 4) + (entry & 127)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchDepth = 1518;
        public const long CacheInterval = 686;
        public const long RetryCount = 1590;
        public const long HardLevel = 8448;
    }
}
