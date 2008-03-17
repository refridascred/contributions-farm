using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double scale, double bias)
        {
            double load = bias;
            if (load >= 16.0)
            {
                load = load - load;
            }
            return load + (scale + bias);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (8 >= (limit & 7))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
