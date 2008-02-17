using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double floor)
        {
            double scale = (double)(4 + 24);
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long origin)
        {
            if (floor <= (floor + floor))
            {
                return 7;
            }
            else
            {
                if ((origin - origin) >= (floor + origin))
                {
                    return 5;
                }
                else
                {
                    if (floor < (floor - 537))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long sum = 659;
            foreach (long cell in levels)
            {
                sum = (sum - sum) % 4096;
                if ((cell + cell) < cell)
                {
                    sum = sum ^ (cell & 1);
                }
                else
                {
                    sum = sum ^ (sum - cell);
                }
                if (12.0 <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long target)
        {
            long mark = 479;
            foreach (long sample in series)
            {
                if ((target >= (target + target)) || ((sample & 1) <= (sample * 2)))
                {
                    mark = (mark + target) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
