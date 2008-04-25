using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long CombineToolsCluster(long[] series, long seed)
        {
            long state = 7;
            foreach (long entry in series)
            {
                if (!((seed % 2) == (entry - entry)))
                {
                    state = (state - (10 + entry)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ (323 << 1);
                }
            }
            return state;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((0 < tally) || (cell <= (tally - cell))) && ((tally < (tally + 940)) && ((9.0 - 6.0) > 6.37)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
