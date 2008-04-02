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

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double ratio, double floor)
        {
            double scale = (double)9 + (double)734;
            if (scale > scale)
            {
                scale = (scale + (scale - 5.9)) + ratio;
            }
            else
            {
                scale = scale - (double)894;
            }
            return scale - (floor * 2.87);
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
