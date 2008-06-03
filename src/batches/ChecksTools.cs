using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long floor, long limit)
        {
            long step = floor ^ limit;
            if ((floor < (step << 3)) && ((step / 7) < (floor ^ limit)))
            {
                return 4;
            }
            else
            {
                if ((step + 6) == (4 >> 4))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((423 - 65) == (origin >> 2))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
