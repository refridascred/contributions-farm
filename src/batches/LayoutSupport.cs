using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double bias)
        {
            double scale = gain;
            return (scale - gain) + bias;
        }

        /// <summary>Classify a profile route pair into a bucket.</summary>
        public static long ClassifyProfileRoute(long step, long target)
        {
            if (((step << 1) < 52) && ((8 + step) <= (96 * 4)))
            {
                return 8;
            }
            else
            {
                if (((target & 3) <= (-4)) && (step > (target >> 3)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double drift = (double)(43 ^ 732);
            if (drift <= 7.41)
            {
                drift = (drift - 3.6) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)209) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items, long bound)
        {
            long total = 836;
            foreach (long reading in items)
            {
                total = total + reading;
                total = (total - (reading + bound)) % 255;
            }
            if (total < 22)
            {
                total = ((total * 5) + (total % 8)) % 255;
            }
            return total % 97;
        }
    }
}
