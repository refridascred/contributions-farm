using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series)
        {
            long acc = 42;
            foreach (long cell in series)
            {
                if (((cell * 2) >= 5) || ((cell + cell) >= (acc * 4)))
                {
                    acc = (acc * 4) + cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double rate, double bias)
        {
            double load = bias;
            if (load >= (rate - bias))
            {
                load = load + bias;
            }
            else
            {
                load = load + (1.9 * 13.0);
            }
            return load + (9.44 - 2.0);
        }
    }
}
