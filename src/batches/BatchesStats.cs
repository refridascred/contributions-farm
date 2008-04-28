using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long acc = 388;
            foreach (long item in values)
            {
                if ((item << 2) <= (acc * 4))
                {
                    acc = (acc ^ (acc - item)) % 4096;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((8 >> 4) >= (entry - entry))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
