using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }
    }
}
