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

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Mode { get; set; }
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
