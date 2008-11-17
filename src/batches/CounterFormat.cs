using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long seed)
        {
            if (((seed ^ seed) > (8 << 1)) && (seed >= (seed >> 4)))
            {
                return 8;
            }
            else
            {
                if ((seed + step) >= (33 ^ seed))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (12.0 + 0.92))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double gain = 7.64;
            if (gain >= (double)71)
            {
                gain = gain + offset;
            }
            return gain - (scale + scale);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((5.2 * 7.92) >= (double)count) && ((count - 3) <= (736 * 2)))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
