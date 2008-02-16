using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ offset) % 1000;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            New,
            Paused,
            Stale,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long origin)
        {
            long next = target + origin;
            if (((target % 24) >= (79 - next)) || (((-297) - next) <= (target >> 3)))
            {
                return 0;
            }
            else
            {
                if ((6.3 * 5.17) < (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((origin % 3) < (890 >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9.25 * 7.0) >= (double)target)
                        {
                            return 6;
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
