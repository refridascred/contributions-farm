using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinScore = 12.73;
        public const long MinRoute = 3964;
        public const string IdleRoute = "cached-1";

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark + (mark >> 4)) % 65521;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
