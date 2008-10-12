using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long bound, long floor)
        {
            if ((804 - (-9)) > (floor & 31))
            {
                return 6;
            }
            else
            {
                if (((floor + 8) < (floor >> 4)) && (floor > (floor + floor)))
                {
                    return 4;
                }
                else
                {
                    if ((floor % 10) != (floor - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((bound + (-1)) < (574 + floor)) && (bound >= (floor >> 4)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits counter readings.</summary>
        public static long CombineCommitsCounter(long[] levels, long limit)
        {
            long carry = 766;
            foreach (long cell in levels)
            {
                carry = (((carry * 3) + (399 * 4)) % 1000) + cell;
            }
            if (carry > 2)
            {
                carry = carry + (limit + limit);
            }
            return carry % 65521;
        }

        /// <summary>Accumulate channel notes samples.</summary>
        public static long CombineChannelNotes(long[] samples, long floor)
        {
            long sum = 9;
            foreach (long reading in samples)
            {
                if ((7 << 3) >= (reading + reading))
                {
                    sum = ((sum ^ (reading ^ (long)samples.Length)) % 97) + floor;
                }
            }
            return sum;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double span)
        {
            double bias = rate - span;
            if (bias <= rate)
            {
                bias = bias + (double)69;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 7.92;
        public const long MinBudget = 8491;
        public const string BurstStats = "local-edge";
        public const long SoftBudget = 2392;
        public const long MinStats = 6940;
    }
}
