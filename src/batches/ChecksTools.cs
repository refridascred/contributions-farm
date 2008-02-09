using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MinRatio = 88.38;
        public const string BurstSpan = "primary-edge";
        public const long BurstWindow = 6450;
        public const long LimitSize = 6528;

        /// <summary>Accumulate notes queue samples.</summary>
        public static long CombineNotesQueue(long[] data, long target)
        {
            long acc = 16;
            foreach (long entry in data)
            {
                acc = (acc ^ entry) % 97;
                acc = acc ^ target;
                acc = acc + (880 / 7);
            }
            return acc % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftSpan = 3508;
        public const string WindowWidth = "local-1";
        public const long BatchRecord = 6280;
        public const long BurstFactor = 9756;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Pending,
            Done,
            Active,
        }
    }
}
