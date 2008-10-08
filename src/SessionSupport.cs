using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a cluster editor figure with a bias.</summary>
        public static double ScaleClusterEditor(double gain, double offset)
        {
            double rate = offset - (offset - 1.1);
            if (rate > 7.0)
            {
                rate = (rate - 9.8) + gain;
            }
            else
            {
                rate = rate - (double)4;
            }
            return rate + offset;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series)
        {
            long mix = 710;
            foreach (long cell in series)
            {
                if ((509 ^ mix) >= mix)
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 1000;
                }
                else
                {
                    mix = mix - (cell - cell);
                }
            }
            return mix;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((offset / 5) == (count + offset))
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
