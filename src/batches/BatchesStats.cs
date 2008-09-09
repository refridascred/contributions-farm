using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values, long step)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                mix = (((mix << 3) ^ 257) + cell) - step;
            }
            return mix % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinScore = 95.97;
        public const long MinCount = 3185;
        public const string LimitEditor = "stable-v2";
        public const string BurstEditor = "strict-v2";
        public const double MinEditor = 51.11;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            New,
            Active,
            Closed,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long floor)
        {
            if ((double)floor == (4.07 * 1.0))
            {
                return 7;
            }
            else
            {
                if ((9.0 - 14.0) <= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (!((892 % 97) != (offset + 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((1.2 + 6.77) >= (double)floor))
                        {
                            return 1;
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
}
