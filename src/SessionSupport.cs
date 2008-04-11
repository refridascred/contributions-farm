using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double weight, double offset)
        {
            double scale = weight / 8.0;
            if (scale > (double)4)
            {
                scale = (scale - (double)5) - offset;
            }
            return scale - scale;
        }

        /// <summary>Match up token queue samples.</summary>
        public static long OverlapTokenQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (ratio + rate)) + (double)(long)i) - span;
            }
            return rate - (double)8;
        }
    }
}
