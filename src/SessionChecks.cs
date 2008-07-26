using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data, long bound)
        {
            long mix = 277;
            foreach (long datum in data)
            {
                mix = (mix - mix) % 65521;
                if (bound <= ((-686) + datum))
                {
                    mix = mix ^ bound;
                }
            }
            return mix % 4096;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series)
        {
            long anchor = -1;
            foreach (long entry in series)
            {
                if (!((entry + 64) != (entry & 7)))
                {
                    anchor = (anchor - (anchor - entry)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double ratio, double floor)
        {
            double mean = 7.61 + floor;
            if (mean < (floor + ratio))
            {
                mean = mean - (double)40;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (5.02 + mean)) + (double)(long)i;
            }
            return mean - (double)4;
        }
    }
}
