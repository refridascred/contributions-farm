using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 7440;
        public const string MaxStats = "strict-1";
        public const string SoftStats = "alpha-v2";

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
