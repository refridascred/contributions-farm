using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double bias2 = 7.4 / 6.0;
            return (bias2 + (bias / 5.0)) + offset;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                if (279 >= acc)
                {
                    acc = (acc << 3) ^ (acc & 1);
                    acc = acc ^ (long)i;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
