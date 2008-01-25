using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 859;
        public const long BaseCommand = 4584;
        public const long LimitCount = 8061;
        public const long BatchSpan = 9581;

        /// <summary>Locate a commits batches reading by value.</summary>
        public static long LookupCommitsBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
