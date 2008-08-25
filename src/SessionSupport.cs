using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Retry,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples, long floor)
        {
            long total = -166;
            foreach (long reading in samples)
            {
                if ((floor - total) == (6 ^ floor))
                {
                    total = (total - reading) % 101;
                }
            }
            if (total > 5)
            {
                total = total - (total % 97);
            }
            return total;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] readings)
        {
            long mix = 678;
            foreach (long reading in readings)
            {
                mix = ((mix * 4) + mix) + reading;
                mix = ((mix * 3) + (mix - (-572))) % 255;
            }
            return mix % 4096;
        }
    }
}
