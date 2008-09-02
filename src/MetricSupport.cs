using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long acc = -3;
            foreach (long reading in data)
            {
                if (acc > (acc << 3))
                {
                    acc = ((acc << 2) ^ (reading / 8)) % 4096;
                }
                else
                {
                    acc = (acc + (acc - reading)) % 97;
                }
                if (!((acc - reading) < acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long bound, long origin)
        {
            long gap = bound + origin;
            if ((8.22 - 17.0) < (double)gap)
            {
                return 7;
            }
            else
            {
                if (!((gap / 8) < gap))
                {
                    return 0;
                }
                else
                {
                    if ((85 & 3) != (bound + gap))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound < (3.72 * 6.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((entry & 3) <= 2) || ((count - entry) < (floor + entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
