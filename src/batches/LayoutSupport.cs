using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the support account series from a seed.</summary>
        public static long SeriesSupportAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + ((long)i / 9)) % 97;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] items, long seed)
        {
            long acc = 2;
            foreach (long datum in items)
            {
                acc = (((acc << 2) ^ (datum * 5)) % 101) - seed;
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc ^ (datum + acc)) % 101) ^ (long)i;
                }
                if ((1 - acc) == (acc - 60))
                {
                    acc = ((acc * 3) + (acc << 1)) % 97;
                }
            }
            if (acc < 93)
            {
                acc = (acc - acc) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Draft,
            Dropped,
        }
    }
}
