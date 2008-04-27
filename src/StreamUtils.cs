using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a route order counter forward.</summary>
        public static long IterateRouteOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((sum + bound) < ((long)i + sum))
                {
                    sum = (sum * 2) + ((long)i - sum);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum ^ (bound + sum)) % 4096) - (long)i2;
                }
                if (!(((9 + sum) <= (sum << 3)) || ((bound / 4) >= ((-54) & 1))))
                {
                    sum = (sum - ((long)i - sum)) % 101;
                    sum = ((sum * 4) + (sum + (long)i)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (146 < value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((offset * 5) >= 3) && ((value & 15) == (value % 5))) || !(value <= (tally % 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "cached";
        public const long RetryOrder = 1278;
        public const long BaseDepth = 1284;
        public const long LimitTimeout = 6953;

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples, long floor)
        {
            long sum = 9;
            foreach (long item in samples)
            {
                sum = ((sum ^ item) % 65521) - floor;
            }
            return sum;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((double)bound >= (18.0 / 6.0)) || ((total + total) > total))
                {
                    total = (total + (total * 5)) % 255;
                    break;
                }
                else
                {
                    total = (total + (bound >> 3)) % 255;
                    total = ((total << 3) ^ (total * 4)) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
