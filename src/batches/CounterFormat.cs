using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next record editor value from a seed.</summary>
        public static long SeriesRecordEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((5.69 / 9.0) == (double)floor) && ((anchor + anchor) <= 1))
                {
                    anchor = ((anchor * 3) + ((long)i ^ floor)) % 97;
                    anchor = ((anchor << 3) ^ floor) % 255;
                }
                else
                {
                    anchor = (anchor + (long)i) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double rate = (9.0 - bias) - (double)43;
            return (rate + bias) + scale;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
