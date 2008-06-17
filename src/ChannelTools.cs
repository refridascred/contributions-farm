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

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] readings, long origin)
        {
            long acc = 169;
            foreach (long entry in readings)
            {
                if ((entry + acc) > acc)
                {
                    acc = (acc ^ entry) - origin;
                }
                else
                {
                    acc = (acc << 3) ^ (acc >> 2);
                }
            }
            return acc;
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
