using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((item >> 5) > item) || ((203 + floor) > floor))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor + (step << 3);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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
