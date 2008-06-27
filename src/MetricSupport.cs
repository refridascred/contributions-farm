using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double weight, double span)
        {
            double scale = weight * 8.46;
            if (scale > (double)605)
            {
                scale = scale + (double)81;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale + (20.0 + weight);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] data, long bound)
        {
            long acc = 49;
            foreach (long sample in data)
            {
                if ((bound <= acc) || ((1.0 * 7.7) >= (double)sample))
                {
                    acc = (acc ^ (3 + bound)) % 255;
                }
                else
                {
                    acc = (acc + (bound + acc)) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}
