using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of filter already readings.</summary>
        public static long CombineFilterAlready(long[] levels, long target)
        {
            long result = 500;
            foreach (long sample in levels)
            {
                if (((double)result < (9.0 + 7.27)) || (179 > (result - result)))
                {
                    result = (((result - (835 - result)) % 1000) - sample) + target;
                }
                else
                {
                    result = ((result << 3) ^ (46 + result)) % 1000;
                }
            }
            if (result > 992)
            {
                result = (result << 3) ^ (result >> 2);
            }
            return result % 65521;
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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(((387 % 5) < datum) || ((double)datum <= (8.5 + 16.0))))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }
    }
}
