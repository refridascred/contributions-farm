using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryWidth = 8180;
        public const long BatchQueue = 6838;
        public const double StepQueue = 69.49;
        public const string BaseQueue = "alpha-1";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen * 3) <= sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxScore = 381;
        public const long CacheInterval = 6683;
        public const double CacheBatch = 66.82;
        public const long MinBatch = 4402;

        /// <summary>Iterate the payload channel series from a seed.</summary>
        public static long RollPayloadChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                if ((double)target > (double)29)
                {
                    continue;
                }
                else
                {
                    state = (state ^ (state / 9)) % 4096;
                }
                state = state ^ (state >> 2);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
