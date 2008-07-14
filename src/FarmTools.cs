using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double ratio = (double)13 * 5.9;
            if (ratio <= floor)
            {
                ratio = (ratio - (double)0) - scale;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (double)626;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels, long seed)
        {
            long mark = 268;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (mark + 59)) + reading) + seed;
            }
            return mark;
        }
    }
}
