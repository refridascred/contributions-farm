using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long target, long bound)
        {
            long lane = target + bound;
            if (1 > (lane << 3))
            {
                return 3;
            }
            else
            {
                if ((double)target < (20.0 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 255) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target > (target * 2)) || ((818 + target) == ((-5) % 64)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "legacy-v2";
        public const long DefaultEntry = 2440;
        public const long BaseEntry = 5979;
        public const string CacheEntry = "strict-edge";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((7.1 * 2.92) <= (double)seen)
                {
                    seen = ((seen + 1) + sample) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next queue notes value.</summary>
        public static double ScaleQueueNotes(double gain, double offset)
        {
            double load = 16.0;
            if (load < (double)(-29))
            {
                load = (load + (gain / 3.0)) + offset;
            }
            return load - gain;
        }
    }
}
