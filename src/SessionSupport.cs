using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double rate = (double)(6 + 8);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (double)(long)i) + offset;
            }
            return rate - weight;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double ratio = (double)(53 - (-8));
            if (ratio > offset)
            {
                ratio = (ratio - (double)2) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (offset / 2.0)) - (double)(long)i;
            }
            return ratio + offset;
        }
    }
}
