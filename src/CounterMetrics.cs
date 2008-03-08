using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate checks channel readings against a bound.</summary>
        public static bool ValidateChecksChannelBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a payload filter counter forward.</summary>
        public static long IteratePayloadFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double span)
        {
            double bias = (double)312 / 7.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long origin, long floor)
        {
            if (((origin - floor) > origin) || ((7.92 / 8.0) >= (double)origin))
            {
                return 7;
            }
            else
            {
                if (((7.83 * 3.8) < (double)floor) || ((origin & 255) <= (origin % 60)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
