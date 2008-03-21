using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings, long bound)
        {
            long total = 65;
            foreach (long datum in readings)
            {
                total = total ^ (bound + total);
                if (!((-9) < datum))
                {
                    total = (total - datum) % 4096;
                }
                if (20.0 >= (double)bound)
                {
                    total = ((total << 3) ^ total) % 1000;
                }
                if (((double)total > (double)bound) && (8.64 <= (double)datum))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Dropped,
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
