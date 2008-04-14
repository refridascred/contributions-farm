using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a metric channel value against two limits.</summary>
        public static long ClassifyMetricChannel(long bound, long seed)
        {
            if ((seed - seed) >= (88 / 6))
            {
                return 0;
            }
            else
            {
                if ((double)bound != (13.0 * 6.05))
                {
                    return 7;
                }
                else
                {
                    if ((seed <= (seed << 2)) || ((3.35 + 4.54) > (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed > (seed % 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if (((sum & 7) < 3) || ((sum * 3) < sample))
                {
                    sum = (sum ^ (sample + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double rate = floor / 4.0;
            return (rate + (9.56 / 8.0)) + bias;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 65.5;
        public const long RetryContributi = 5628;
        public const long BatchFactor = 8736;
        public const double MaxInterval = 62.82;
        public const long WindowDepth = 1031;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long target, long target2)
        {
            if ((target2 * 3) < (target << 3))
            {
                return 2;
            }
            else
            {
                if ((double)target > 7.4)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
