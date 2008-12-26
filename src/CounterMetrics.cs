using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = mix - ((long)i + floor);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a tools notes reading.</summary>
        public static double BlendToolsNotes(double scale, double bias)
        {
            double drift = bias / 3.0;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (bias * 8.44)) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Grade a channel route value against two limits.</summary>
        public static long BucketChannelRoute(long origin, long limit)
        {
            long delta = origin + limit;
            if (19.0 > (double)limit)
            {
                return 8;
            }
            else
            {
                if ((937 + limit) != (limit >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((538 * 3) != (origin * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - delta) <= limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double offset)
        {
            double rate2 = (rate + offset) * 2.6;
            if (rate2 <= (rate2 / 6.0))
            {
                rate2 = rate2 + 2.7;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + offset;
        }
    }
}
