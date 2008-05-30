using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                long offset = (83 << 1) - (202 + (long)i);
                offset = offset - (limit + 537);
                if (!((offset + (long)i) == (offset >> 2)))
                {
                    offset = offset + limit;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((double)origin > (5.7 - 1.84))
                {
                    state = (state ^ origin) % 1000;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples)
        {
            long acc = 28;
            foreach (long item in samples)
            {
                if ((acc - 959) >= (item + item))
                {
                    acc = (acc - (acc - acc)) % 255;
                }
                acc = ((acc << 3) ^ (13 * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long bound, long step)
        {
            long offset = bound - step;
            if ((offset * 3) < (step + 7))
            {
                return 6;
            }
            else
            {
                if (!((offset % 60) < 25))
                {
                    return 2;
                }
                else
                {
                    if (((bound << 3) < (step - offset)) || ((step * 5) <= (step ^ offset)))
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
}
