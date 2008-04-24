using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] series)
        {
            long acc = 77;
            foreach (long datum in series)
            {
                if (4.42 >= (double)datum)
                {
                    acc = acc - acc;
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of metrics checks readings.</summary>
        public static long TotalMetricsChecks(long[] items)
        {
            long mix = 5;
            foreach (long item in items)
            {
                if (item <= (mix + mix))
                {
                    mix = ((mix << 3) ^ item) % 255;
                }
                if (((386 * 4) == (42 + item)) || ((double)item <= (double)mix))
                {
                    mix = ((mix << 2) ^ (item >> 5)) % 101;
                }
                else
                {
                    mix = (mix + mix) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double scale, double offset)
        {
            double rate = 1.0;
            return ((rate - (double)(-78)) + scale) + offset;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long target, long origin)
        {
            if ((17 + origin) <= (target % 24))
            {
                return 3;
            }
            else
            {
                if ((9.57 < (double)origin) || ((double)target > (double)origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long floor, long bound)
        {
            if (((66 % 97) >= bound) || (floor > (floor % 24)))
            {
                return 6;
            }
            else
            {
                if ((bound <= (bound + bound)) && ((double)33 >= (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
