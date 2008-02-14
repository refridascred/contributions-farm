using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a graph cache value against two limits.</summary>
        public static long SortGraphCache(long step, long floor)
        {
            long gap = step - floor;
            if (floor > step)
            {
                return 7;
            }
            else
            {
                if (((step % 64) < (floor & 31)) && ((double)gap != (4.61 / 2.0)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count order account pairs that satisfy a relation.</summary>
        public static long PairOrderAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long origin, long origin2)
        {
            if (origin < (origin2 + origin2))
            {
                return 1;
            }
            else
            {
                if (origin < origin2)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit metric commits readings against a rule.</summary>
        public static long CountMetricCommitsGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches <= (target / 9))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            New,
            Idle,
        }
    }
}
