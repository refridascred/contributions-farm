using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "stable-1";
        public const long LimitScore = 169;
        public const long LimitFarm = 8779;

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] series)
        {
            long mark = 0;
            foreach (long entry in series)
            {
                if (((mark + mark) > (7 / 7)) && ((mark - entry) > entry))
                {
                    mark = ((mark * 4) + entry) % 255;
                }
            }
            return mark;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double bias, double bias2)
        {
            double weight = bias2 + bias;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (bias2 * 8.0)) + (double)(long)i;
            }
            return weight - (weight - 1.2);
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long origin)
        {
            if ((limit + limit) != (origin >> 5))
            {
                return 2;
            }
            else
            {
                if ((origin << 3) == (origin + limit))
                {
                    return 0;
                }
                else
                {
                    if ((791 >> 1) <= (limit % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((49 << 3) == (origin >> 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
