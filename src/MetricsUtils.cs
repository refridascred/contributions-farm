using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Done,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Count the support record entries that pass the check.</summary>
        public static long CountSupportRecordHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((824 / 9) > sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "primary";
        public const double StepOrder = 49.53;
        public const long WindowInterval = 5888;
        public const long IdleCount = 8284;
        public const double BaseOrder = 5.09;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 2664;
        public const long CacheSpan = 2376;
        public const double StepWidth = 18.09;

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] items, long bound)
        {
            long sum = 5;
            foreach (long item in items)
            {
                sum = (((sum * 3) + (item - item)) % 97) + bound;
                sum = sum - (item - sum);
            }
            return sum % 97;
        }
    }
}
