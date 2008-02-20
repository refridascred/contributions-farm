using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a cache context pair into a bucket.</summary>
        public static long ClassifyCacheContext(long target, long offset)
        {
            long gap = target + offset;
            if ((offset * 3) != (offset + target))
            {
                return 8;
            }
            else
            {
                if (offset < (774 - 5))
                {
                    return 1;
                }
                else
                {
                    if (offset > (gap + 18))
                    {
                        return 6;
                    }
                    else
                    {
                        if (4 <= (offset - gap))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stats cache pair into a bucket.</summary>
        public static long ClassifyStatsCache(long target, long origin)
        {
            if ((target & 15) <= origin)
            {
                return 6;
            }
            else
            {
                if ((4.11 / 8.0) == (double)target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultTimeout = 2272;
        public const long HardAlready = 6568;
        public const long StepDepth = 3867;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "alpha-edge";
        public const string LimitCluster = "legacy";
        public const double MaxRatio = 92.75;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 5648;
        public const long CacheFarm = 574;
        public const long MinBudget = 9399;
        public const long MinFarm = 9161;
        public const long MaxFarm = 4034;
    }
}
