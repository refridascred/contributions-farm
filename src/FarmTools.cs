using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter profile readings against a rule.</summary>
        public static long TallyFilterProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((((double)seen <= (3.53 + 4.9)) && ((909 + seen) <= (seen * 4))) || ((895 >> 1) <= seen))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
