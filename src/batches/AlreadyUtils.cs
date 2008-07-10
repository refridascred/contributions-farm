using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks route reading by value.</summary>
        public static long LocateChecksRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long seed)
        {
            long slot = origin + seed;
            if ((double)origin >= (16.0 - 0.7))
            {
                return 3;
            }
            else
            {
                if (origin < seed)
                {
                    return 1;
                }
                else
                {
                    if ((46 + seed) != (slot & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 60) == (slot + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate contributi profile samples.</summary>
        public static long CombineContributiProfile(long[] samples)
        {
            long mix = 180;
            foreach (long entry in samples)
            {
                if ((double)entry >= (0.5 * 1.56))
                {
                    mix = mix ^ (entry * 4);
                }
                else
                {
                    mix = (mix + (415 - mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double gain = (double)8 + weight;
            if (gain > (7.9 + weight))
            {
                gain = (gain + (gain - gain)) - floor;
            }
            else
            {
                gain = gain - (weight - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + 15.0) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
