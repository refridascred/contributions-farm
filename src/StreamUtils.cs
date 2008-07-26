using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
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
