using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batch queue value against two limits.</summary>
        public static long BucketBatchQueue(long floor, long floor2)
        {
            if ((809 - floor) >= (floor - 29))
            {
                return 8;
            }
            else
            {
                if (floor < (floor2 + floor2))
                {
                    return 4;
                }
                else
                {
                    if (((floor2 - floor2) == (floor2 - floor)) && (floor <= (floor - floor2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item >> 4) > count)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long bound, long origin)
        {
            if ((origin + origin) > 2)
            {
                return 0;
            }
            else
            {
                if (!(origin <= (bound * 3)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (1.32 + 6.9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound != (7.3 + 9.6)) || (origin < (bound / 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading >= (matches - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double bias, double bias2)
        {
            double load = bias2;
            if (load <= bias)
            {
                load = load + 12.0;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (9.68 - bias)) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
