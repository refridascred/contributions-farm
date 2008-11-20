using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long floor)
        {
            long cur = target + floor;
            if (5.25 < (double)target)
            {
                return 5;
            }
            else
            {
                if ((double)cur > (5.1 * 2.71))
                {
                    return 2;
                }
                else
                {
                    if ((target - 64) < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target - cur) == (floor >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metric already figure with a bias.</summary>
        public static double ScaleMetricAlready(double bias, double span)
        {
            double scale = bias / 9.0;
            if (scale > span)
            {
                scale = scale + scale;
            }
            return scale + (8.09 + scale);
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
