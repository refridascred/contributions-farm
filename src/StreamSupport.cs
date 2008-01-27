using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two batches context measurements.</summary>
        public static double ScaleBatchesContext(double weight, double span)
        {
            double rate = (double)2 / 2.0;
            if (rate > (span * 1.08))
            {
                rate = (rate - rate) - weight;
            }
            else
            {
                rate = rate - (span - span);
            }
            return rate - (double)(-553);
        }

        /// <summary>Check that every layout window entry stays within the limit.</summary>
        public static bool CheckLayoutWindowLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
