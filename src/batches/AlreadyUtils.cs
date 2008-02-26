using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9603;
        public const long BurstInterval = 8002;
        public const long BurstBatches = 8994;
        public const long DefaultBudget = 9913;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long seed2)
        {
            if ((seed2 ^ seed2) < 32)
            {
                return 7;
            }
            else
            {
                if ((seed2 / 2) > seed)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (3.0 < (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long target)
        {
            long slot = bound - target;
            if ((77 & 7) == (bound % 12))
            {
                return 1;
            }
            else
            {
                if (((slot & 3) > slot) && ((4.4 / 6.0) < (double)slot))
                {
                    return 4;
                }
                else
                {
                    if (((target << 2) < (bound * 3)) && ((double)slot <= (3.0 * 1.14)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((target + slot) >= (slot + target)) && (((-149) * 5) != (slot << 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
