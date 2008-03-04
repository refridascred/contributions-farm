using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value < (72 << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((origin / 5) > hits)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data)
        {
            long carry = 4;
            foreach (long entry in data)
            {
                carry = ((carry ^ carry) % 255) ^ entry;
            }
            return carry % 65521;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] data)
        {
            long state = 3;
            foreach (long reading in data)
            {
                if ((double)5 <= (double)state)
                {
                    state = (state - (reading << 3)) % 65521;
                }
                if (reading >= (76 - reading))
                {
                    state = (state * 3) + (reading - reading);
                }
            }
            return state;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
