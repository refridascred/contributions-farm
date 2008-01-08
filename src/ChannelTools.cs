using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
