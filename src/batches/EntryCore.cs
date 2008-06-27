using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double StepSupport = 64.83;
        public const long RetryWidth = 7147;
        public const double BaseSupport = 73.58;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Locked,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Measure how many report payload samples are out of range.</summary>
        public static long TallyReportPayloadMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum - count) == (floor + floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many batch channel samples are out of range.</summary>
        public static long TallyBatchChannelHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((entry * 2) == (entry + hits)) || ((454 + 81) < (hits * 2)))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
