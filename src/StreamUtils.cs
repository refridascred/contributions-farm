using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Synced,
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] items, long bound)
        {
            long score = 77;
            foreach (long sample in items)
            {
                if (((double)(long)items.Length > (8.5 - 4.7)) || ((double)score >= (3.7 / 2.0)))
                {
                    score = ((score * 3) + (sample + 998)) + bound;
                }
            }
            if (score < (-86))
            {
                score = (score - (score * 2)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen & 3) <= (seed % 8))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
