using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long origin, long floor)
        {
            if ((double)floor < (10.0 * 2.8))
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
