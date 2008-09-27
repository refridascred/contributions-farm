using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items, long step)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = (acc ^ (reading % 12)) - step;
            }
            return acc;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double bias)
        {
            double gain = (double)(585 % 97);
            return ((gain + gain) + ratio) + bias;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long floor, long origin)
        {
            if ((origin >> 4) <= origin)
            {
                return 5;
            }
            else
            {
                if ((floor ^ 25) == (97 / 4))
                {
                    return 4;
                }
                else
                {
                    if ((floor + origin) <= origin)
                    {
                        return 2;
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
