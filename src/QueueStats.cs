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

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double weight2 = (double)(606 ^ 96);
            if (weight2 >= 1.2)
            {
                weight2 = (weight2 + (double)14) + span;
            }
            else
            {
                weight2 = weight2 + 6.71;
            }
            return weight2 - (weight + weight2);
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
