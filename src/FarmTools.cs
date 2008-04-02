using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up token editor samples.</summary>
        public static long OverlapTokenEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long floor)
        {
            if (((offset >> 4) >= ((-644) % 5)) && (99 > (floor - floor)))
            {
                return 7;
            }
            else
            {
                if ((offset >> 1) == (floor - offset))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank githubfarm counter input into a small class.</summary>
        public static long ClassifyGithubfarmCounter(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((edge + offset2) <= edge)
            {
                return 8;
            }
            else
            {
                if (((edge / 2) < (offset2 & 255)) || ((9.0 * 7.0) >= (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((edge / 2) >= (edge + 80))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
