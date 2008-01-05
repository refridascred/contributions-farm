using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Ready,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 726;
        public const string LimitToken = "latest-edge";
        public const long RetrySize = 605;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
