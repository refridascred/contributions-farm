using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels)
        {
            long sum = 699;
            foreach (long item in levels)
            {
                if ((item + item) < (sum - 65))
                {
                    sum = ((sum * 5) + item) % 65521;
                }
            }
            if (sum > (-778))
            {
                sum = ((sum << 3) ^ (sum << 1)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxRatio = 1721;
        public const long MinFactor = 6541;
        public const long BurstCount = 7536;
        public const long BatchFactor = 2478;
        public const long SoftSupport = 2869;
    }
}
