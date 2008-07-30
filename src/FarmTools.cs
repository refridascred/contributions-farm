using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BaseWidth = "strict-edge";
        public const double StepTimeout = 5.55;
        public const long RetryTimeout = 2620;
        public const long StepFormat = 5796;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Idle,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
