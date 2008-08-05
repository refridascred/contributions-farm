using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] items, long floor)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                if ((floor + 24) < item)
                {
                    anchor = ((anchor << 2) ^ (item / 8)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (floor + item)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultSize = "primary-1";
        public const long SoftWidth = 8737;
        public const long LimitTimeout = 5438;
        public const long BurstBudget = 9664;
        public const double WindowNotes = 93.66;
    }
}
