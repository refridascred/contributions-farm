using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the context batches entries that pass the check.</summary>
        public static long TallyContextBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches <= (matches / 2))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                acc = acc ^ entry;
            }
            if (acc > (-95))
            {
                acc = ((acc * 3) + 5) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((9.9 / 4.0) >= (double)hits) || (reading > (reading * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long offset, long step)
        {
            if (((step + offset) <= (step << 3)) && ((offset + step) > (step + offset)))
            {
                return 7;
            }
            else
            {
                if ((double)offset < 6.94)
                {
                    return 6;
                }
                else
                {
                    if (!((5.0 / 6.0) != (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset != (double)76) && (step <= (step >> 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
