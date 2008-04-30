using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate checks order samples.</summary>
        public static long CombineChecksOrder(long[] series)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                if ((reading + anchor) != (653 + reading))
                {
                    anchor = anchor + reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double gain, double offset)
        {
            double drift = offset;
            if (drift < offset)
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - (drift - 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)97) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Pending,
            Locked,
        }
    }
}
