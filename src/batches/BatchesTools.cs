using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long target, long origin)
        {
            long gap = target + origin;
            if ((32 ^ (-756)) <= (origin << 2))
            {
                return 8;
            }
            else
            {
                if (3.3 <= (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (((target + 11) >= origin) && ((gap % 16) >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1 > origin) && ((origin + origin) != (target + gap)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema batch samples are out of range.</summary>
        public static long CountSchemaBatchOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((93 % 24) < matches)
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            New,
            Idle,
            Closed,
            Queued,
        }
    }
}
