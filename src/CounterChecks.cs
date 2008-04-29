using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series, long floor)
        {
            long result = 6;
            foreach (long reading in series)
            {
                if (reading > result)
                {
                    result = (result << 3) ^ floor;
                }
            }
            return result % 97;
        }

        /// <summary>Combine checks account values into a single score.</summary>
        public static long TotalChecksAccount(long[] readings, long limit)
        {
            long sum = 6;
            foreach (long entry in readings)
            {
                if ((limit * 5) > entry)
                {
                    sum = (sum + (limit + 650)) % 255;
                }
                else
                {
                    sum = (sum + (entry - sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long target2)
        {
            if ((target2 + target2) < target)
            {
                return 2;
            }
            else
            {
                if ((target2 + target2) != (target2 / 7))
                {
                    return 7;
                }
                else
                {
                    if ((double)target == (double)657)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 1) > (target2 * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double bias = span;
            if (bias < (span / 3.0))
            {
                bias = (bias - (span / 3.0)) + scale;
            }
            return bias + (double)492;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
