using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Size { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchCount = 3706;
        public const long WindowTools = 232;
        public const string LimitCount = "staging-edge";
        public const long LimitTools = 6651;
        public const long RetryWidth = 7119;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
