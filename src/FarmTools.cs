using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Locked,
            Draft,
            New,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long floor)
        {
            if ((target + 6) != (target & 255))
            {
                return 0;
            }
            else
            {
                if ((6.9 * 3.7) >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor > (3.4 * 5.4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a entry metric reading by value.</summary>
        public static long LocateEntryMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
