using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long result = 287;
            foreach (long cell in levels)
            {
                result = (result * 2) + limit;
                if (cell < limit)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long seed, long seed2)
        {
            if ((55 + seed) > seed)
            {
                return 5;
            }
            else
            {
                if (!((seed2 * 3) <= seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed << 3) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + seed) != (seed2 & 127))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((7.8 < (double)value) && ((double)value == (3.84 + 11.0))))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
