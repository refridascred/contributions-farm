using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long step)
        {
            if ((step % 24) <= (offset + 562))
            {
                return 8;
            }
            else
            {
                if (((step ^ offset) <= (693 - step)) || (step <= offset))
                {
                    return 0;
                }
                else
                {
                    if ((step << 3) >= (step % 60))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((item * 5) == (hits << 1)) && ((5 + hits) < item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCount = "cached-v2";
        public const string CacheCommand = "standard-edge";
        public const string DefaultCount = "staging-1";

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
            public bool Region { get; set; }
        }
    }
}
