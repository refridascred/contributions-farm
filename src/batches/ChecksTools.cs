using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long seed)
        {
            long delta = origin + seed;
            if (((double)delta >= (14.0 + 13.0)) || ((3.0 * 5.89) == (double)delta))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (double)9)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long seed, long floor)
        {
            long edge = seed ^ floor;
            if ((seed << 1) > (5 + edge))
            {
                return 8;
            }
            else
            {
                if ((48 + floor) <= (floor / 4))
                {
                    return 5;
                }
                else
                {
                    if ((0 < (edge % 8)) && ((1.8 - 8.8) <= (double)floor))
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

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                long offset = (518 - limit) + (limit - mark);
                mark = ((mark * 2) + (offset % 12)) % 255;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
