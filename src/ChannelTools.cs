using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 78.2;
        public const long LimitTimeout = 5293;
        public const long SoftAlready = 6555;
        public const long IdleDepth = 1453;

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long offset)
        {
            long sum = 367;
            foreach (long sample in levels)
            {
                if (((sample - offset) != (sum - sample)) || ((sample * 5) > (offset % 10)))
                {
                    sum = ((sum << 3) ^ (sum + sample)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Synced,
            Draft,
        }
    }
}
