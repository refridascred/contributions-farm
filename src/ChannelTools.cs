using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 9346;
        public const long SoftNotes = 1789;
        public const string DefaultNotes = "open";

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            New,
            Locked,
            Failed,
            Pending,
        }
    }
}
