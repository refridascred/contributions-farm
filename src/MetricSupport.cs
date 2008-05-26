using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            long prev = floor ^ floor2;
            if ((floor2 & 255) <= (floor % 3))
            {
                return 5;
            }
            else
            {
                if ((3 <= (floor * 2)) || ((floor2 * 4) != (floor2 >> 3)))
                {
                    return 2;
                }
                else
                {
                    if (16.0 <= (double)prev)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6.0 + 18.0) != (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double weight, double span)
        {
            double drift = (double)((-581) ^ (-8));
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (span - 1.4)) - (double)(long)i) - weight;
            }
            return drift - (4.0 / 9.0);
        }
    }
}
