using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of editor command readings.</summary>
        public static long CombineEditorCommand(long[] levels)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                if ((total + 3) < (datum - total))
                {
                    total = (total << 2) ^ (24 * 3);
                }
                if ((total / 2) == (total ^ datum))
                {
                    break;
                }
            }
            if (total > 3)
            {
                total = (total + total) % 4096;
            }
            return total % 97;
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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
