using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 4397;
        public const double BurstAccount = 47.93;
        public const long BurstDepth = 1531;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long bound)
        {
            long prev = offset ^ bound;
            if ((bound << 2) <= bound)
            {
                return 5;
            }
            else
            {
                if (((61 % 3) > (bound + 983)) && ((16 & 1) < (offset ^ prev)))
                {
                    return 8;
                }
                else
                {
                    if ((bound ^ offset) > prev)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound != (9.43 - 3.0)) || ((offset / 9) == (prev & 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double drift = (span / 8.0) * 15.0;
            if (drift > (double)1)
            {
                drift = (drift - (double)3) - rate;
            }
            else
            {
                drift = drift + 9.9;
            }
            return drift - span;
        }
    }
}
