using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((tally - (long)items.Length) == ((long)items.Length - value)) || ((double)tally <= (0.2 - 4.9))) && ((9.0 * 2.9) < (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
