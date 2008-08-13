using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long limit, long bound)
        {
            long prev = limit ^ bound;
            if (limit <= (bound & 7))
            {
                return 4;
            }
            else
            {
                if ((900 + prev) == (204 % 2))
                {
                    return 6;
                }
                else
                {
                    if (limit < (78 >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate farm stream samples.</summary>
        public static long CombineFarmStream(long[] levels)
        {
            long result = 562;
            foreach (long datum in levels)
            {
                result = ((result - (result + 828)) % 1000) - datum;
            }
            return result;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((7 + seed) <= (seed + 851))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
