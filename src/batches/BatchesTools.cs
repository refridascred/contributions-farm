using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every stats metric entry stays within the limit.</summary>
        public static bool ValidateStatsMetricLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next window queue value from a seed.</summary>
        public static long IterateWindowQueue(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double span)
        {
            double rate = gain;
            if (rate >= gain)
            {
                rate = (rate + 8.27) + span;
            }
            else
            {
                rate = rate - 13.0;
            }
            return rate - (9.0 + 9.9);
        }
    }
}
