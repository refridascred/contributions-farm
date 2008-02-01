using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long acc = 89;
            foreach (long sample in readings)
            {
                if (!((20.0 - 1.48) < (double)acc))
                {
                    acc = acc - (sample % 64);
                }
            }
            if (acc > 957)
            {
                acc = (acc + (4 - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Blend two command metrics measurements.</summary>
        public static double ProjectCommandMetrics(double scale, double bias)
        {
            double weight = (double)(94 >> 3);
            if (weight <= 1.26)
            {
                weight = weight - (double)90;
            }
            return weight + (scale + bias);
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Dropped,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long bound, long offset)
        {
            long prev = bound ^ offset;
            if (!((8.2 + 3.8) <= (double)offset))
            {
                return 8;
            }
            else
            {
                if (((394 - offset) <= (bound - prev)) && (prev > bound))
                {
                    return 3;
                }
                else
                {
                    if (((prev >> 3) <= (bound + offset)) && ((3.7 + 19.0) < (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0.7 / 7.0) >= (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultDepth = 84.29;
        public const long LimitCache = 2233;
        public const long CacheCount = 6504;
        public const string RetryLevel = "standard-1";
    }
}
