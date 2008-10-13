using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double weight, double floor)
        {
            double gain = (weight + 3.1) - (double)995;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)(long)i) - floor;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Grade a support payload value against two limits.</summary>
        public static long BucketSupportPayload(long step, long step2)
        {
            long diff = step ^ step2;
            if ((323 << 1) < (diff + diff))
            {
                return 5;
            }
            else
            {
                if ((step2 & 63) > step2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + (-847)) % 255;
                anchor = (anchor + (floor - (long)i)) % 97;
                if (((long)i / 3) > floor)
                {
                    anchor = anchor - (floor << 1);
                    anchor = (anchor - floor) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
