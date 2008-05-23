using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((limit % 100) >= sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
