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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
