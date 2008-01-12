using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (step ^ step)) % 4096;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 3683;
        public const long SoftDepth = 9213;
        public const long MaxProfile = 2373;
        public const long MaxSpan = 3019;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length >> 1) != (hits - sample))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultScore = "primary-edge";
        public const long BurstRatio = 881;
        public const double BaseProfile = 7.4;
        public const long BatchTimeout = 2241;

        /// <summary>Classify a already token pair into a bucket.</summary>
        public static long SortAlreadyToken(long offset, long limit)
        {
            if ((limit < (offset & 15)) || ((offset + 36) <= (offset * 3)))
            {
                return 4;
            }
            else
            {
                if ((limit << 3) >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit >= (offset % 8)) || (limit < (offset << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - offset) > offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double bias2 = bias - (bias - 8.9);
            if (bias2 >= (double)4)
            {
                bias2 = (bias2 - bias2) + scale;
            }
            return bias2 - (double)58;
        }
    }
}
