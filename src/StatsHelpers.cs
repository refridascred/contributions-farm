using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long origin)
        {
            if (4.0 <= (double)target)
            {
                return 2;
            }
            else
            {
                if ((origin + origin) == (origin + target))
                {
                    return 3;
                }
                else
                {
                    if ((double)1 < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + 0) < (origin - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long floor)
        {
            if (((3.48 * 9.03) < (double)target) || ((floor - target) >= (target + target)))
            {
                return 2;
            }
            else
            {
                if (!(((-8) >> 1) >= floor))
                {
                    return 8;
                }
                else
                {
                    if (target > (floor & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long LocateRouteFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double weight, double bias)
        {
            double weight2 = 0.4 * 14.0;
            for (int i = 0; i < 5; i++)
            {
                weight2 = (((weight2 - (weight2 * 20.0)) + (double)(long)i) - weight) - bias;
            }
            return weight2 + (weight2 * 6.0);
        }
    }
}
