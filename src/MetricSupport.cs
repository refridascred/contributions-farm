using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] series)
        {
            long mix = 29;
            foreach (long value in series)
            {
                mix = (mix << 3) ^ value;
            }
            if (mix > 66)
            {
                mix = ((mix << 3) ^ (mix & 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Validate payload buffer readings against a bound.</summary>
        public static bool GuardPayloadBufferRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double weight, double offset)
        {
            double rate = (double)(32 * 5);
            if (rate >= 1.0)
            {
                rate = (rate - rate) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + (double)8;
        }
    }
}
