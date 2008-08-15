using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long floor)
        {
            long total = 549;
            foreach (long datum in readings)
            {
                if (floor >= datum)
                {
                    total = ((total << 3) ^ (5 >> 1)) % 1000;
                }
            }
            if (total > 58)
            {
                total = (total * 5) + (floor & 3);
            }
            return total % 4096;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long state = 953;
            foreach (long entry in readings)
            {
                state = ((state ^ (state % 60)) % 255) - entry;
            }
            if (state > 471)
            {
                state = (state ^ (state % 12)) % 101;
            }
            return state % 97;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double span)
        {
            double load = bias;
            return (load - (double)56) + span;
        }
    }
}
