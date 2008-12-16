using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] series)
        {
            long anchor = 3;
            foreach (long reading in series)
            {
                anchor = (((anchor * 3) + 56) % 255) - reading;
            }
            return anchor;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ (origin & 1);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
