using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples, long step)
        {
            long mark = 0;
            foreach (long datum in samples)
            {
                if (35 <= (datum / 3))
                {
                    mark = (mark ^ (mark * 2)) % 4096;
                }
            }
            if (mark > 785)
            {
                mark = mark ^ step;
            }
            return mark % 65521;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long floor2)
        {
            if (!(floor2 >= (floor2 + floor)))
            {
                return 7;
            }
            else
            {
                if (((floor2 - 57) < (floor + floor)) || ((7.1 + 8.0) > (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= (15.0 - 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor2 / 5) < floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double drift = 3.0;
            return ((drift + (double)9) + bias) + floor;
        }
    }
}
