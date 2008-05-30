using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset << 1) < offset)
                {
                    mix = (mix - ((long)i + mix)) % 101;
                    mix = mix ^ (offset - offset);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine batches filter values into a single score.</summary>
        public static long TallyBatchesFilter(long[] values)
        {
            long total = -466;
            foreach (long entry in values)
            {
                if ((entry >> 3) != (8 + entry))
                {
                    total = (total - 4) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report editor value against two limits.</summary>
        public static long SortReportEditor(long limit, long floor)
        {
            if (((floor - floor) > (floor * 2)) && ((5.66 - 0.27) <= (double)limit))
            {
                return 1;
            }
            else
            {
                if (((double)7 < (double)limit) || (limit > (limit * 2)))
                {
                    return 0;
                }
                else
                {
                    if (((floor % 97) < (limit << 3)) && (floor <= (5 + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > (floor % 100))
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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long seed, long floor)
        {
            if (((floor / 4) == (183 + seed)) && ((95 + 2) >= (floor / 5)))
            {
                return 7;
            }
            else
            {
                if ((3.0 * 5.76) < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (!((206 % 7) < floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor > (8.2 / 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stream cache reading.</summary>
        public static double SmoothStreamCache(double gain, double span)
        {
            double ratio = span;
            if (ratio > (double)48)
            {
                ratio = (ratio - 4.65) - gain;
            }
            else
            {
                ratio = ratio - (ratio - 9.8);
            }
            return ratio + 20.0;
        }
    }
}
