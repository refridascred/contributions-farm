using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings, long offset)
        {
            long mix = 93;
            foreach (long cell in readings)
            {
                mix = (((mix + (mix % 3)) % 97) ^ cell) - offset;
            }
            return mix;
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

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 728;
        public const long BaseTimeout = 3569;
        public const long IdleGraph = 1190;
        public const long MaxGraph = 1920;

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
