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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if (12.0 <= (6.06 + 5.4))
            {
                return 1;
            }
            else
            {
                if ((74 + floor2) <= (cur - floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor > (8.8 + 5.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur % 5) != (floor << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
