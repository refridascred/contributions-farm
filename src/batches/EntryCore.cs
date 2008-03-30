using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data)
        {
            long sum = 3;
            foreach (long sample in data)
            {
                sum = ((sum * 4) + sum) + sample;
            }
            return sum;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum + (origin >> 1)) % 4096;
                sum = sum - (origin + origin);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double rate, double floor)
        {
            double rate2 = (rate - 4.77) + (rate + rate);
            if (rate2 > (rate2 + rate))
            {
                rate2 = (rate2 + 3.1) + floor;
            }
            return rate2 - (double)293;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long floor, long target)
        {
            if ((34 + 189) > floor)
            {
                return 8;
            }
            else
            {
                if (((-849) < target) || ((double)(-12) == (double)floor))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
