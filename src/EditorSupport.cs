using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 3421;
        public const double HardFormat = 38.85;
        public const long CacheFormat = 866;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count >= (9.64 - 2.7))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 3358;
        public const string BatchBudget = "alpha-edge";
        public const string CacheBatch = "cached-v2";
        public const long IdleWidth = 9866;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a already stats value against two limits.</summary>
        public static long ClassifyAlreadyStats(long target, long seed)
        {
            if (9.71 > (double)seed)
            {
                return 8;
            }
            else
            {
                if (target < 43)
                {
                    return 6;
                }
                else
                {
                    if (target > 578)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
