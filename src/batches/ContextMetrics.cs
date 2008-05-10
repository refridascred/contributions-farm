using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double load = offset;
            return load + ratio;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format checks readings against a rule.</summary>
        public static long CountFormatChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((0 * 5) >= count)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits + bound) != (bound + bound)) || ((double)hits >= (2.1 - 5.15)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
