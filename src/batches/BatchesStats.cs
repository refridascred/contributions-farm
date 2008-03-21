using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ (bound - 5)) % 4096;
                if (((total - total) >= bound) && ((3.0 / 3.0) != (double)bound))
                {
                    total = (total - (896 >> 4)) % 255;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a cache metric value against two limits.</summary>
        public static long GradeCacheMetric(long limit, long bound)
        {
            long edge = limit ^ bound;
            if ((edge % 100) < (879 % 7))
            {
                return 4;
            }
            else
            {
                if (!((edge ^ bound) < (limit % 2)))
                {
                    return 2;
                }
                else
                {
                    if (((edge >> 4) >= (edge + edge)) || ((bound / 6) != (edge << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
