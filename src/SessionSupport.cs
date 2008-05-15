using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count / 2) >= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Retry,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxOrder = 88.93;
        public const long MinOrder = 4165;
        public const long BaseDepth = 5167;
    }
}
