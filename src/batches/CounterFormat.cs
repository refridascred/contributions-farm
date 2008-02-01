using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine profile route values into a single score.</summary>
        public static long FoldProfileRoute(long[] samples)
        {
            long score = -567;
            foreach (long sample in samples)
            {
                if ((score + sample) > (score / 7))
                {
                    score = (score ^ (1 * 5)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many tools order samples are out of range.</summary>
        public static long CountToolsOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally >= (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a tools metric value against two limits.</summary>
        public static long BucketToolsMetric(long origin, long bound)
        {
            long edge = origin ^ bound;
            if ((bound - bound) != (origin & 127))
            {
                return 4;
            }
            else
            {
                if (((39 << 1) > (edge >> 4)) && ((bound ^ origin) != (bound + (-593))))
                {
                    return 3;
                }
                else
                {
                    if (((edge + edge) > origin) || (91 > (0 + edge)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
