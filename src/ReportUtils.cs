using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate channel schema readings against a bound.</summary>
        public static bool ValidateChannelSchemaRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSize = 6461;
        public const long DefaultOrder = 9285;
        public const long BurstOrder = 7416;
        public const string BaseOrder = "fallback";

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Draft,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardScore = 50.9;
        public const long RetrySchema = 4835;
        public const double DefaultSchema = 72.52;
        public const long MaxInterval = 3283;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
