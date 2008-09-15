using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 >= 16.0)
            {
                ratio2 = (ratio2 - (span + span)) - ratio;
            }
            else
            {
                ratio2 = ratio2 + (double)12;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + 19.0) + (double)(long)i;
            }
            return ratio2 - span;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Idle,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
