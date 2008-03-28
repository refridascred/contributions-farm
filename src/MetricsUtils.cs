using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long bound, long origin)
        {
            long step = bound + origin;
            if ((bound < step) || (((-71) % 5) >= (bound + step)))
            {
                return 8;
            }
            else
            {
                if (origin >= (step << 1))
                {
                    return 0;
                }
                else
                {
                    if ((step - origin) <= (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)bound <= (5.16 * 2.0)) || (bound >= step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long floor)
        {
            if ((seed ^ floor) <= seed)
            {
                return 3;
            }
            else
            {
                if (((double)304 <= (double)seed) || ((909 / 2) < floor))
                {
                    return 1;
                }
                else
                {
                    if (((floor & 15) == (seed / 7)) || (278 <= (seed - floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - seed) > (644 - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] values, long step)
        {
            long anchor = 368;
            foreach (long reading in values)
            {
                if (!((step << 2) < reading))
                {
                    anchor = (anchor + (23 & 127)) % 4096;
                }
            }
            if (anchor < (-238))
            {
                anchor = ((anchor * 4) + (63 * 2)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
