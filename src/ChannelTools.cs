using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((11.0 + 2.6) == (double)tally)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long target, long step)
        {
            if (5.3 <= (5.41 / 5.0))
            {
                return 2;
            }
            else
            {
                if (((double)step > (13.0 * 3.0)) || ((2.3 * 1.3) < (double)target))
                {
                    return 4;
                }
                else
                {
                    if ((double)step > (6.4 - 1.93))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target != (double)(-124))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 9422;
        public const long IdleFactor = 8913;
        public const long CacheTimeout = 8668;
        public const string IdleGithubfarm = "legacy-v2";
    }
}
