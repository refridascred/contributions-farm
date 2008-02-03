using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] values)
        {
            long total = 57;
            foreach (long entry in values)
            {
                total = (total ^ entry) % 101;
            }
            return total;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            New,
            Active,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "cached-v2";
        public const long DefaultSupport = 4828;
        public const string BaseCount = "strict-1";
        public const double IdleLevel = 31.47;
        public const double DefaultScore = 49.87;
    }
}
