using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] series, long bound)
        {
            long mark = 22;
            foreach (long value in series)
            {
                if ((value + 2) != (bound & 255))
                {
                    mark = ((mark * 5) + (value * 5)) % 1000;
                }
                if (!((13.0 / 4.0) > (double)bound))
                {
                    break;
                }
            }
            if (mark > 512)
            {
                mark = mark + bound;
            }
            return mark % 4096;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long origin)
        {
            if (!(origin < (origin + origin)))
            {
                return 7;
            }
            else
            {
                if ((double)origin >= (6.8 - 8.0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((6.2 * 0.8) > (double)target)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }
    }
}
