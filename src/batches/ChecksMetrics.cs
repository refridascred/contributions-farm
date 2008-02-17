using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank checks stream input into a small class.</summary>
        public static long GradeChecksStream(long floor, long bound)
        {
            if ((double)bound != (double)floor)
            {
                return 2;
            }
            else
            {
                if ((6.12 * 2.0) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound >= (363 << 3)) || ((4.8 - 0.3) <= (double)bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor & 31) >= (floor + floor)) && (8.0 <= (double)floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a queue profile reading.</summary>
        public static double ScaleQueueProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= (double)18)
            {
                load = (load + scale) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
