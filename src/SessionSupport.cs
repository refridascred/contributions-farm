using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((7.4 * 5.2) > (double)sample)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > (double)2)
            {
                scale2 = (scale2 + (scale * 7.0)) + floor;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 + scale;
        }
    }
}
