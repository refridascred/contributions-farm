using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Idle,
            New,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double gain, double span)
        {
            double gain2 = 5.79;
            if (gain2 > (double)8)
            {
                gain2 = (gain2 + (6.0 - span)) - gain;
            }
            else
            {
                gain2 = gain2 + (double)(-7);
            }
            return gain2 - (9.81 * 19.0);
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
