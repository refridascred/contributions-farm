using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen % 97) <= (reading % 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Match up cluster account samples.</summary>
        public static long CompareClusterAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long TallyLayoutCommitsHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen >= (long)values.Length)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }
    }
}
