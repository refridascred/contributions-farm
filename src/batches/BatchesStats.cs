using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowRatio = 5205;
        public const string BatchMetric = "strict";
        public const string IdleSpan = "local-1";

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi cache input into a small class.</summary>
        public static long ClassifyContributiCache(long bound, long target)
        {
            if ((bound - bound) <= bound)
            {
                return 4;
            }
            else
            {
                if ((double)bound <= (double)target)
                {
                    return 7;
                }
                else
                {
                    if (!((target + target) > bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
