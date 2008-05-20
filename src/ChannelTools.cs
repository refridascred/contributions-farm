using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long target, long floor)
        {
            if (((floor >> 2) != (floor & 127)) || ((floor - floor) == (target & 255)))
            {
                return 7;
            }
            else
            {
                if ((target * 3) <= floor)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the commits layout entries that pass the check.</summary>
        public static long CountCommitsLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((9.0 - 9.79) != (double)(long)data.Length)
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks metric samples are out of range.</summary>
        public static long TallyChecksMetricOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= (reading << 1))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
