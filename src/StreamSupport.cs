using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinWidth = 4845;
        public const long BatchStats = 5834;
        public const long MinInterval = 1087;
        public const long IdleStats = 1409;
        public const string MaxStats = "local-1";

        /// <summary>Match up stats filter samples.</summary>
        public static long CompareStatsFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long target, long floor)
        {
            if (!((double)floor < 8.8))
            {
                return 0;
            }
            else
            {
                if (!((double)floor <= (7.0 + 3.9)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
