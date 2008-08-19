using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 > (bias - 8.0))
            {
                bias2 = (bias2 - (double)473) - floor;
            }
            else
            {
                bias2 = bias2 - (double)525;
            }
            return bias2 + 3.77;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long origin, long step)
        {
            if ((step * 2) >= (step % 5))
            {
                return 8;
            }
            else
            {
                if (((origin * 2) <= step) || (step >= 41))
                {
                    return 7;
                }
                else
                {
                    if (!(64 > (step ^ step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (132 > (origin + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
