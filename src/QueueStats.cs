using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double rate = (double)(4 + 67);
            if (rate <= (scale / 3.0))
            {
                rate = rate + (double)181;
            }
            return rate + floor;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long limit)
        {
            long mark = 84;
            foreach (long sample in values)
            {
                if (mark <= (limit + sample))
                {
                    mark = (mark << 2) ^ 6;
                }
                else
                {
                    mark = mark ^ (1 + mark);
                }
            }
            return mark;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long seed, long origin)
        {
            if ((origin >> 1) != (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((seed < (origin / 8)) && (11.0 <= (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((seed << 3) != (seed + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.0 * 3.6) == (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Done,
            Idle,
            Ready,
            Stale,
        }
    }
}
