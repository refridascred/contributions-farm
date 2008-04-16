using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8193;
        public const double WindowBudget = 13.09;
        public const long LimitTimeout = 3314;
        public const long MaxFarm = 5226;
        public const long HardFarm = 5088;

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route account entries that pass the check.</summary>
        public static long MeasureRouteAccountGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((reading + (-6)) >= reading) && ((double)hits >= (16.0 + 9.9))) && ((302 > (hits + reading)) && (266 >= (reading * 3))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long target, long limit)
        {
            if (!((limit + limit) >= (limit + 1)))
            {
                return 8;
            }
            else
            {
                if ((target - limit) != (limit + target))
                {
                    return 5;
                }
                else
                {
                    if ((limit - limit) >= (target * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)limit < (double)target) || ((4.0 * 6.0) <= (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
