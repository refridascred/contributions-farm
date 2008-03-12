using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up command stats samples.</summary>
        public static long OverlapCommandStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long floor, long offset)
        {
            if ((offset - 6) <= floor)
            {
                return 1;
            }
            else
            {
                if ((6 / 2) > (649 - floor))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (floor & 63)) % 255;
                if (sum >= (3 + sum))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + (floor + 92)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double gain = (double)2 / 9.0;
            if (gain > offset)
            {
                gain = (gain + (0.4 * 4.1)) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (offset - 7.0)) + (double)(long)i;
            }
            return gain + 5.09;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 3.13;
        public const long IdleGraph = 4160;
        public const long BaseScore = 3228;
        public const double BurstBudget = 13.68;
    }
}
