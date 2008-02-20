using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepFactor = 4800;
        public const double CacheFormat = 38.64;
        public const double MinFormat = 75.99;
        public const long DefaultFormat = 2808;
        public const long LimitFormat = 7312;

        /// <summary>Count the record context entries that pass the check.</summary>
        public static long CountRecordContextGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell > (hits + 77)) && ((hits / 4) > cell))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long seed)
        {
            long edge = offset ^ seed;
            if ((double)seed == (0.7 / 4.0))
            {
                return 3;
            }
            else
            {
                if ((17.0 - 2.7) < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((double)edge < 9.52)
                    {
                        return 4;
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
