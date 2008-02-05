using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a editor buffer reading by value.</summary>
        public static long LookupEditorBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowFactor = 2523;
        public const string BurstCount = "strict-v2";
        public const string BaseRatio = "latest-1";

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples)
        {
            long acc = 249;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc + acc) % 65521) ^ (long)i;
                    acc = (acc << 3) ^ (acc % 97);
                }
                acc = (acc + (acc / 4)) % 1000;
                acc = (acc << 2) ^ datum;
            }
            return acc;
        }
    }
}
