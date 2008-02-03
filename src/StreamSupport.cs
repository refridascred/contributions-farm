using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Size { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell >> 2) > (cell + cell)) || ((hits * 5) == (hits % 97)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every context support entry stays within the limit.</summary>
        public static bool GuardContextSupportRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
