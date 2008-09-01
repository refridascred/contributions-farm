using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long bound, long step)
        {
            if ((bound + bound) < step)
            {
                return 1;
            }
            else
            {
                if (((step << 1) != (bound + bound)) || ((step >> 4) <= bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound - step) >= (step % 100))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step > (bound + step))
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

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double gain, double bias)
        {
            double weight = gain;
            if (weight > (weight * 0.18))
            {
                weight = (weight - (gain * 9.2)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (double)321;
        }

        /// <summary>Grade a metrics entry value against two limits.</summary>
        public static long BucketMetricsEntry(long origin, long target)
        {
            if ((target >> 4) <= (origin - target))
            {
                return 0;
            }
            else
            {
                if ((origin - target) <= (origin % 16))
                {
                    return 1;
                }
                else
                {
                    if ((target % 16) < (7 >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Failed,
            New,
            Retry,
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double scale = offset;
            if (scale < ratio)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (0.8 * 13.0)) + (double)(long)i;
            }
            return scale + (4.96 * 3.79);
        }
    }
}
