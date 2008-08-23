using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the support tools series from a seed.</summary>
        public static long SeriesSupportTools(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)target > (9.0 + 3.31)))
                {
                    state = (state - (target ^ state)) % 65521;
                }
                if (!(587 >= (target + state)))
                {
                    state = ((state << 2) ^ 464) % 1000;
                    break;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many queue format samples are out of range.</summary>
        public static long MeasureQueueFormatOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((5.0 + 0.9) != (double)(long)data.Length)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long step2)
        {
            long lane = step + step2;
            if (!((double)step > (6.0 - 3.0)))
            {
                return 2;
            }
            else
            {
                if (((lane - step2) > (step2 * 5)) || ((double)step2 != (double)step))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first format notes entry that matches the target.</summary>
        public static long LookupFormatNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheBudget = 4762;
        public const long WindowLayout = 4953;
        public const double SoftLevel = 82.81;
        public const long WindowInterval = 2217;
        public const long BaseSpan = 2521;
    }
}
