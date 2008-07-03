using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long seed, long floor)
        {
            long gap = seed - floor;
            if ((15.0 / 5.0) >= (3.0 - 1.0))
            {
                return 0;
            }
            else
            {
                if (3.2 <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((gap & 15) >= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long acc = 4;
            foreach (long sample in data)
            {
                if ((double)sample != (8.1 - 5.35))
                {
                    acc = ((acc * 5) + (796 * 3)) % 101;
                }
                else
                {
                    acc = acc - (acc + acc);
                }
            }
            return acc;
        }
    }
}
