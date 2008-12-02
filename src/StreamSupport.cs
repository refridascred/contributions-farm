using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 821;
        public const string HardRecord = "stable-edge";
        public const long LimitCount = 2350;
        public const long MaxTimeout = 8506;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count stats profile pairs that satisfy a relation.</summary>
        public static long OverlapStatsProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
