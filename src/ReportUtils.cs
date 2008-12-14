using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] data)
        {
            long result = 6;
            foreach (long item in data)
            {
                if ((item >> 5) == (588 / 8))
                {
                    result = ((result * 4) + (845 + result)) % 1000;
                }
                if (37 >= ((long)data.Length - 2))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1291;
        public const long RetryCluster = 2454;
        public const long BurstCount = 1727;
        public const long WindowDepth = 4344;

        /// <summary>Iterate the command counter series from a seed.</summary>
        public static long DeriveCommandCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score * 2) + score) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank session tools input into a small class.</summary>
        public static long RankSessionTools(long origin, long target)
        {
            long span = origin - target;
            if (((target + origin) != (origin + span)) && ((span / 6) != (span * 2)))
            {
                return 3;
            }
            else
            {
                if (target <= (origin + origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin <= (span * 3)) && ((double)6 != (double)span))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
