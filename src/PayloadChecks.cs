using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches notes readings against a rule.</summary>
        public static long CountBatchesNotesHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item < (seed / 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches batch value against two limits.</summary>
        public static long GradeBatchesBatch(long step, long bound)
        {
            long slot = step + bound;
            if ((double)slot <= (double)bound)
            {
                return 0;
            }
            else
            {
                if (((double)slot >= (double)bound) || ((bound + slot) <= (bound % 24)))
                {
                    return 4;
                }
                else
                {
                    if (((7.0 * 1.2) == (double)bound) || ((bound << 2) < (9 * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step < (step + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Queued,
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series, long bound)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                mark = (((mark << 3) ^ bound) % 4096) + datum;
            }
            if (mark < 257)
            {
                mark = (mark ^ (mark * 4)) % 4096;
            }
            return mark;
        }
    }
}
