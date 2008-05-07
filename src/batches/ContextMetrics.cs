using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long step, long step2)
        {
            long diff = step ^ step2;
            if ((diff >> 2) > step2)
            {
                return 5;
            }
            else
            {
                if ((3 - step) <= (step2 + step))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches < (value % 97))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue profile value against two limits.</summary>
        public static long SortQueueProfile(long floor, long bound)
        {
            long prev = floor + bound;
            if ((prev + floor) >= (bound ^ 81))
            {
                return 7;
            }
            else
            {
                if (((bound * 3) == (9 >> 3)) || (bound <= 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)prev < (4.0 + 8.7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a queue graph counter forward.</summary>
        public static long SeriesQueueGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor ^ anchor) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
