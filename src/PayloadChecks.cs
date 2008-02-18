using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 3) ^ (origin % 12)) % 101;
                if (!((double)state > (double)73))
                {
                    state = (state ^ (state * 3)) % 97;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long seed, long floor)
        {
            if ((995 % 24) > (seed * 3))
            {
                return 0;
            }
            else
            {
                if (floor > (seed / 6))
                {
                    return 5;
                }
                else
                {
                    if (!((11.0 - 1.0) >= (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long mark = 9;
            foreach (long datum in items)
            {
                if (((datum * 5) > datum) || (((-255) * 2) <= (datum + mark)))
                {
                    mark = (mark * 5) + (datum + datum);
                }
            }
            return mark % 65521;
        }

        /// <summary>Audit stats batches readings against a rule.</summary>
        public static long CountStatsBatchesHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally - tally) == (tally - 7))
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
