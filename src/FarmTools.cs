using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 92.01;
        public const long BatchRoute = 6603;
        public const long IdleRoute = 3759;
        public const long SoftSpan = 4951;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long seed)
        {
            if (!((seed + 1) > (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit >> 3) >= (limit & 15))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry - step) <= 83) || ((((long)readings.Length & 15) == (step << 2)) || ((2 + tally) <= step)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
