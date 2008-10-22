using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a profile commits pair into a bucket.</summary>
        public static long RankProfileCommits(long limit, long origin)
        {
            long lane = limit ^ origin;
            if ((lane ^ limit) >= origin)
            {
                return 0;
            }
            else
            {
                if (limit > ((-831) - 4))
                {
                    return 7;
                }
                else
                {
                    if ((origin - limit) < (8 >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin & 7) < origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardInterval = "cached";
        public const long BurstStream = 3583;
        public const long MaxStream = 5188;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long seed)
        {
            if ((seed < (seed + offset)) && (seed > (offset >> 4)))
            {
                return 8;
            }
            else
            {
                if (seed < 541)
                {
                    return 5;
                }
                else
                {
                    if ((seed + seed) > (offset ^ seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 793;
        public const double MaxLevel = 8.95;
        public const long SoftChecks = 3112;
        public const double CacheSpan = 80.13;
    }
}
