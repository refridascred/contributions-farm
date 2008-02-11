using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i < (seed << 3))
                {
                    result = (result << 3) ^ ((long)i & 127);
                    result = ((result << 3) ^ seed) % 1000;
                    continue;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
