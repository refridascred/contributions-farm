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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long target, long target2)
        {
            long diff = target - target2;
            if ((target - target2) != (target >> 4))
            {
                return 5;
            }
            else
            {
                if ((target2 < (target2 % 3)) || (((-754) - diff) == (target + 20)))
                {
                    return 2;
                }
                else
                {
                    if (!((target2 ^ diff) >= (diff - diff)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
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
