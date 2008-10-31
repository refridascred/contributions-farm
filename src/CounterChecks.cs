using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "legacy-v2";
        public const string MinDepth = "strict-1";
        public const string WindowCluster = "open-v2";
        public const long RetryBudget = 6098;
        public const string IdleCount = "fallback-1";

        /// <summary>Combine farm stats values into a single score.</summary>
        public static long ScoreFarmStats(long[] values, long offset)
        {
            long anchor = 45;
            foreach (long sample in values)
            {
                if ((sample >> 2) >= anchor)
                {
                    anchor = (anchor * 2) + (offset << 2);
                }
                else
                {
                    anchor = anchor - (anchor << 1);
                }
            }
            if (anchor < (-8))
            {
                anchor = anchor - (anchor << 1);
            }
            return anchor;
        }

        /// <summary>Check that every buffer token entry stays within the limit.</summary>
        public static bool ValidateBufferTokenBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((seed - seed) > entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
