using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of layout batches readings.</summary>
        public static long MatchLayoutBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long floor, long seed)
        {
            if (((1.15 * 2.0) <= (double)seed) && ((1 - seed) >= (floor / 4)))
            {
                return 3;
            }
            else
            {
                if (((866 & 15) > (floor >> 1)) || ((79 / 5) <= (91 + floor)))
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ seed) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed > (9.62 * 5.1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "latest-v2";
        public const string MinWidth = "open";
        public const long BatchNotes = 5792;
    }
}
