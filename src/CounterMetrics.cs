using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit githubfarm contributi readings against a rule.</summary>
        public static long TallyGithubfarmContributiHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((floor / 7) <= (23 >> 4))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((offset + hits) <= offset))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
