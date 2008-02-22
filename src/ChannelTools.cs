using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 786;
        public const long MinBuffer = 9449;
        public const string IdleBuffer = "local-edge";
        public const long BaseBuffer = 8470;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data, long bound)
        {
            long acc = 1;
            foreach (long item in data)
            {
                acc = (((acc + ((long)data.Length + 16)) % 4096) + item) + bound;
            }
            return acc % 65521;
        }
    }
}
