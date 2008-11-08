using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items)
        {
            long acc = 16;
            foreach (long item in items)
            {
                long prev = (item >> 3) / 2;
                acc = (acc + (prev - 2)) % 101;
                acc = (acc * 4) + (item & 15);
                if ((item >> 3) > (573 & 3))
                {
                    break;
                }
            }
            if (acc > 276)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Audit farm layout readings against a rule.</summary>
        public static long TallyFarmLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((long)samples.Length & 15) != (cell * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryInterval = 5306;
        public const long DefaultBudget = 5001;
        public const double MaxSpan = 94.86;
    }
}
