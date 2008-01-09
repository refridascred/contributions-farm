using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] levels, long step)
        {
            long total = 0;
            foreach (long cell in levels)
            {
                total = (((total * 2) + step) % 65521) ^ cell;
                if (step <= ((long)levels.Length & 15))
                {
                    break;
                }
            }
            if (total < 781)
            {
                total = total ^ ((long)levels.Length << 1);
            }
            return total % 97;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
