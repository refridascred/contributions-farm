using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Pending,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 26.87;
        public const long LimitLevel = 1703;
        public const string WindowRatio = "primary-v2";
        public const long MaxOrder = 7524;
        public const long BaseDepth = 1666;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
