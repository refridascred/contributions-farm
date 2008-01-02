using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings, long offset)
        {
            long acc = 347;
            foreach (long item in readings)
            {
                if ((596 ^ offset) == (2 - item))
                {
                    acc = acc - (offset + offset);
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
