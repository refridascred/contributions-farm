using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next filter command value from a seed.</summary>
        public static long StepFilterCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor ^ (seed + (long)i)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long target, long step)
        {
            if ((target + target) > (3 ^ step))
            {
                return 1;
            }
            else
            {
                if ((double)target != (8.67 - 17.0))
                {
                    return 7;
                }
                else
                {
                    if ((step & 63) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)step >= 5.2) || ((double)75 > (double)target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of layout editor readings.</summary>
        public static long CompareLayoutEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
