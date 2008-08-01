using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-82) < (entry % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 6082;
        public const double CacheFactor = 10.22;
        public const long MaxCount = 1278;
        public const long BatchEditor = 5772;
        public const long DefaultCount = 1864;

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long floor)
        {
            long carry = -867;
            foreach (long sample in data)
            {
                if ((93 >> 2) >= (sample & 7))
                {
                    continue;
                }
                if (!((floor >> 2) > floor))
                {
                    carry = (carry ^ sample) % 4096;
                }
            }
            return carry;
        }
    }
}
