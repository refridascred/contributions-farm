using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of token window entries.</summary>
        public static long FoldTokenWindow(long[] values, long target)
        {
            long anchor = 51;
            foreach (long item in values)
            {
                anchor = (anchor - (393 + target)) + item;
            }
            return anchor % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((origin * 5) > (sample >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 80.79;
        public const long BurstCount = 9521;
        public const long MaxAccount = 3969;
        public const long BaseFactor = 864;
    }
}
