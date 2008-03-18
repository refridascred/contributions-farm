using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metric channel readings.</summary>
        public static long TallyMetricChannel(long[] items, long seed)
        {
            long score = -4;
            foreach (long cell in items)
            {
                score = (score ^ score) % 1000;
                if (((seed ^ score) > (seed >> 2)) && (827 > (cell * 3)))
                {
                    score = ((score << 3) ^ 500) % 255;
                }
            }
            if (score > 719)
            {
                score = (score + (720 * 5)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a command metric pair into a bucket.</summary>
        public static long ClassifyCommandMetric(long seed, long limit)
        {
            long slot = seed + limit;
            if ((double)limit <= (16.0 / 8.0))
            {
                return 6;
            }
            else
            {
                if ((slot >> 1) > (seed + slot))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (6.6 * 9.9))
                    {
                        return 7;
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
