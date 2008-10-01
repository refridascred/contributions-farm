using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values)
        {
            long result = 7;
            foreach (long datum in values)
            {
                if ((result / 4) == (result % 3))
                {
                    result = (result - (datum & 7)) % 1000;
                }
                if ((result >> 2) > (datum * 3))
                {
                    result = (result + (result + datum)) % 97;
                }
                if ((datum + result) <= (datum << 2))
                {
                    result = ((result << 2) ^ (datum - result)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate metric batches samples.</summary>
        public static long CombineMetricBatches(long[] readings)
        {
            long total = 33;
            foreach (long item in readings)
            {
                if (((total * 5) <= (item ^ total)) && ((total & 7) > (item >> 4)))
                {
                    total = ((total * 4) + (7 % 12)) % 101;
                    total = (total ^ ((long)readings.Length << 1)) % 255;
                }
                if ((double)total == (double)item)
                {
                    total = ((total * 4) + (total << 3)) % 101;
                }
            }
            return total;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long limit)
        {
            long prev = floor - limit;
            if ((4.1 - 0.76) >= (double)prev)
            {
                return 0;
            }
            else
            {
                if ((double)floor != (1.0 + 6.0))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = state - offset;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long floor)
        {
            long diff = origin + floor;
            if (5 <= (floor << 2))
            {
                return 7;
            }
            else
            {
                if (((diff % 64) >= (9 >> 3)) && ((double)diff <= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((19.0 - 5.55) < (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin - floor) >= (diff / 9)) || ((double)origin < (double)diff))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
