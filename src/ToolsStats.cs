using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = (total ^ ((long)i << 2)) % 101;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double ratio, double bias)
        {
            double ratio2 = (double)(28 * 5);
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 + ratio2) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (8.07 / 2.0)) + (double)(long)i;
            }
            return ratio2 - (double)58;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long target)
        {
            if ((origin + target) >= (0 << 3))
            {
                return 4;
            }
            else
            {
                if (origin < target)
                {
                    return 2;
                }
                else
                {
                    if (!((origin & 63) > (98 << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a route entry sample.</summary>
        public static long LookupRouteEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((0.5 - 3.6) < (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
