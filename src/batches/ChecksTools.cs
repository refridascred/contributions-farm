using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long bound)
        {
            long slot = floor + bound;
            if (!((bound ^ floor) == (slot - bound)))
            {
                return 0;
            }
            else
            {
                if ((double)(-515) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (floor > (slot & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((slot >> 2) < (slot / 7)) || (bound <= (bound * 5)))
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
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long target)
        {
            if ((target + origin) >= (163 - 5))
            {
                return 1;
            }
            else
            {
                if ((2.0 * 11.0) > (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (origin <= (origin << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) <= (41 ^ origin))
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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((453 > (67 + value)) && ((hits << 1) > (85 + hits)))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitScore = 4670;
        public const double BurstWindow = 77.0;
        public const long BurstWidth = 1875;
    }
}
