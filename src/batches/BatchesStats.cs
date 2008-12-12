using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (bound > (reading - bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up entry command samples.</summary>
        public static long CompareEntryCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long limit)
        {
            long prev = seed + limit;
            if ((double)seed >= (9.4 * 7.2))
            {
                return 7;
            }
            else
            {
                if ((11 - limit) <= (prev << 1))
                {
                    return 2;
                }
                else
                {
                    if ((double)prev >= (17.0 * 4.87))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit << 3) == (seed * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
