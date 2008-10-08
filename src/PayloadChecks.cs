using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum >= (tally << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
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

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((value > count) && (7.3 >= (double)value)) || (((double)count <= 2.0) || ((value - value) >= (value << 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
