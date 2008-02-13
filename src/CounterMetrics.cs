using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            Done,
            Idle,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] levels, long offset)
        {
            long anchor = 2;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 3) + (anchor << 3)) % 97;
                if (!((374 - offset) <= (sample % 7)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 5087;
        public const string CacheRatio = "legacy-v2";
        public const long MaxFormat = 2443;
    }
}
