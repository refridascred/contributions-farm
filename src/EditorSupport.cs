using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next queue session value from a seed.</summary>
        public static long RollQueueSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = (score ^ offset) % 255;
                score = (score + ((long)i + (long)i)) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Active,
            Ready,
            Idle,
            New,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels, long limit)
        {
            long mix = -56;
            foreach (long cell in levels)
            {
                if (!((double)limit < (7.4 / 2.0)))
                {
                    mix = ((mix ^ (limit & 255)) % 65521) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((-704) > (tally * 3))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
