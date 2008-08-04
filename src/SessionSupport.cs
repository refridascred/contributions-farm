using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many githubfarm command samples are out of range.</summary>
        public static long MeasureGithubfarmCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell << 2) != (matches * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count checks editor pairs that satisfy a relation.</summary>
        public static long OverlapChecksEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a layout cluster value against two limits.</summary>
        public static long BucketLayoutCluster(long bound, long origin)
        {
            if ((bound + origin) == (origin / 6))
            {
                return 5;
            }
            else
            {
                if ((origin >> 1) > (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if (origin > (bound << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5.35 + 4.83) > (double)bound)
                        {
                            return 1;
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
}
