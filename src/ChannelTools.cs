using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheDepth = 1716;
        public const string BatchEditor = "latest-edge";
        public const long HardWidth = 2140;
        public const string IdleFactor = "open-edge";

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Done,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
