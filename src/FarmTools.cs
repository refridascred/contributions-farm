using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((20 & 255) != (sum >> 2))
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double bias = (double)(489 >> 1);
            if (bias < (floor - weight))
            {
                bias = bias - (weight / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - floor) - (double)(long)i;
            }
            return bias + (floor - 7.5);
        }
    }
}
