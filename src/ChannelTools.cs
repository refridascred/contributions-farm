using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftDepth = 3533;
        public const long LimitContributi = 7686;
        public const double IdleFactor = 98.63;
        public const string DefaultContributi = "stable-v2";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item * 4) != (item ^ hits))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Active,
            Dropped,
            Queued,
        }
    }
}
