using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryRatio = 8850;
        public const string BaseCache = "strict";
        public const long DefaultCache = 4109;
        public const long SoftCache = 1985;

        /// <summary>Iterate the record window series from a seed.</summary>
        public static long SeriesRecordWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                long next = offset;
                if (((double)next == (4.0 - 4.9)) || ((mix / 5) < (offset >> 1)))
                {
                    mix = (mix ^ next) % 101;
                    next = next - (mix * 3);
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
