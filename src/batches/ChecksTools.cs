using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every checks stream entry stays within the limit.</summary>
        public static bool CheckChecksStreamRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 570;
        public const string BaseSize = "cached";
        public const long BatchWidth = 7438;
        public const double WindowSpan = 14.53;
    }
}
