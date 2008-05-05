using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a profile schema figure with a bias.</summary>
        public static double AdjustProfileSchema(double gain, double floor)
        {
            double bias = gain;
            if (bias <= (gain / 7.0))
            {
                bias = bias + (floor / 6.0);
            }
            else
            {
                bias = bias + (gain + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (double)(-6);
        }
    }
}
