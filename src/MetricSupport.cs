using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a stream channel reading.</summary>
        public static double ProjectStreamChannel(double gain, double span)
        {
            double rate = (span - span) + 5.1;
            if (rate < span)
            {
                rate = rate - (gain - span);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor + 42;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Look up the position of a contributi session sample.</summary>
        public static long LookupContributiSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
