using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long limit)
        {
            long next = bound ^ limit;
            if ((bound % 24) < (next + limit))
            {
                return 7;
            }
            else
            {
                if (!((0 & 63) < bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)next > (18.0 - 9.27))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound / 8) > (limit + next)) && (6.41 < (double)limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryRatio = "strict";
        public const long CacheRatio = 5302;
        public const long WindowOrder = 9266;
    }
}
