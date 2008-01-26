using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + 801) < (count % 64))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long limit)
        {
            long total = 646;
            foreach (long entry in items)
            {
                total = (total ^ (limit - total)) + entry;
            }
            return total;
        }
    }
}
