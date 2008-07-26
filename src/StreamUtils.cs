using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long floor)
        {
            long sum = 4;
            foreach (long value in series)
            {
                sum = ((sum ^ (sum << 2)) % 4096) - floor;
                if ((double)sum != (9.5 / 2.0))
                {
                    sum = sum + (value % 97);
                }
            }
            if (sum > 3)
            {
                sum = (sum - 227) % 4096;
            }
            return sum;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long limit, long target)
        {
            long cur = limit - target;
            if ((cur * 4) <= (target - target))
            {
                return 7;
            }
            else
            {
                if ((limit & 63) >= cur)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long limit, long limit2)
        {
            if ((double)limit != (5.05 / 5.0))
            {
                return 8;
            }
            else
            {
                if (limit < (limit2 << 1))
                {
                    return 5;
                }
                else
                {
                    if (41 < limit2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + limit) == (29 - limit2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next editor support value.</summary>
        public static double SmoothEditorSupport(double scale, double bias)
        {
            double drift = scale;
            if (drift > scale)
            {
                drift = drift - (double)260;
            }
            return drift - (bias + drift);
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
