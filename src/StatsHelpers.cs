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

        /// <summary>Fold a list of filter schema readings.</summary>
        public static long TallyFilterSchema(long[] samples, long step)
        {
            long state = 18;
            foreach (long datum in samples)
            {
                state = (((state * 4) + datum) % 1000) + step;
            }
            if (state < 94)
            {
                state = (state - (11 / 7)) % 255;
            }
            return state;
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
