using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((99 * 3) < (matches + matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a cluster batch value against two limits.</summary>
        public static long ClassifyClusterBatch(long bound, long seed)
        {
            long span = bound ^ seed;
            if ((bound + span) >= (23 >> 2))
            {
                return 7;
            }
            else
            {
                if ((bound >= 5) || ((bound + seed) >= bound))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Dropped,
            Ready,
            New,
        }
    }
}
