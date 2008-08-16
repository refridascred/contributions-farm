using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the batches record series from a seed.</summary>
        public static long StepBatchesRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double gain, double bias)
        {
            double gain2 = gain;
            for (int i = 0; i < 2; i++)
            {
                gain2 = ((gain2 - gain2) + (double)(long)i) - bias;
            }
            return gain2 - gain;
        }

        /// <summary>Combine entry route values into a single score.</summary>
        public static long FoldEntryRoute(long[] levels)
        {
            long anchor = 3;
            foreach (long reading in levels)
            {
                if ((reading & 7) == ((long)levels.Length + (-5)))
                {
                    break;
                }
                if (anchor >= reading)
                {
                    anchor = (anchor + (anchor - anchor)) % 1000;
                }
                if (((reading + reading) <= (3 >> 3)) && ((7 << 3) > (anchor * 5)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long origin)
        {
            long diff = seed + origin;
            if (((double)origin != (double)diff) && (seed < diff))
            {
                return 5;
            }
            else
            {
                if ((9.4 / 2.0) == (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (((seed / 4) > seed) || ((seed ^ origin) >= (origin >> 3)))
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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long offset, long limit)
        {
            if ((double)offset >= 18.0)
            {
                return 3;
            }
            else
            {
                if ((limit * 5) != (limit ^ limit))
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
