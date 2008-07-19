using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] samples)
        {
            long acc = 75;
            foreach (long datum in samples)
            {
                if (!((8.9 - 7.9) != (double)datum))
                {
                    acc = acc - (acc << 3);
                }
            }
            if (acc < 9)
            {
                acc = (acc - (345 / 4)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Done,
            Ready,
            Idle,
            New,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a token metrics figure with a bias.</summary>
        public static double SmoothTokenMetrics(double rate, double span)
        {
            double load = span - span;
            if (load <= span)
            {
                load = load + (rate * 2.05);
            }
            else
            {
                load = load - (double)4;
            }
            return load - (double)(-38);
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long step)
        {
            if ((double)limit > (double)step)
            {
                return 8;
            }
            else
            {
                if (((double)step <= (6.1 - 4.65)) && (3.1 > (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((step / 4) >= (step - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
