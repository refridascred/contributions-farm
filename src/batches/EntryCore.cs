using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)tally < (double)target)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout cache readings.</summary>
        public static long DigestLayoutCache(long[] values, long floor)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if ((8.2 * 7.0) != (double)reading)
                {
                    total = ((total << 3) ^ (total * 3)) % 4096;
                }
                else
                {
                    total = (total * 5) + total;
                    total = (total - (floor * 4)) % 255;
                }
                total = total + floor;
            }
            if (total > 96)
            {
                total = total + (floor * 5);
            }
            return total;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long acc = 34;
            foreach (long sample in levels)
            {
                if ((step << 1) < 5)
                {
                    acc = (acc << 2) ^ (sample + acc);
                }
                else
                {
                    acc = ((acc << 3) ^ step) % 97;
                }
                if ((sample + acc) < (sample % 12))
                {
                    break;
                }
            }
            if (acc > 40)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 97;
        }
    }
}
