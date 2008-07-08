using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((739 ^ entry) > (hits * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long target, long bound)
        {
            if ((bound / 4) <= (bound >> 3))
            {
                return 7;
            }
            else
            {
                if (target < (21 >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 255) > (target - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(bound > (109 - 978)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 4102;
        public const string HardCluster = "cached-v2";
        public const long DefaultCluster = 2243;
        public const long DefaultFactor = 6926;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor + (target * 4)) % 101;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor + anchor) % 1000) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of cluster command readings.</summary>
        public static long OverlapClusterCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
