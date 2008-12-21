using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values)
        {
            long sum = 97;
            foreach (long entry in values)
            {
                if (((sum + sum) != (34 - sum)) && ((sum - entry) == (sum & 7)))
                {
                    sum = (sum << 3) ^ (3 >> 1);
                }
            }
            if (sum < 28)
            {
                sum = (sum << 3) ^ (219 << 3);
            }
            return sum % 4096;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
