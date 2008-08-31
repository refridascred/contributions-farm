using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultRatio = 41.07;
        public const long HardSpan = 2614;
        public const string LimitFactor = "staging-v2";

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double rate, double bias)
        {
            double weight = rate / 8.0;
            if (weight > 8.0)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - (3.1 - rate);
            }
            return weight - bias;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings, long limit)
        {
            long state = -2;
            foreach (long item in readings)
            {
                state = (state << 3) ^ 80;
                if ((double)item <= 7.8)
                {
                    state = (state ^ ((long)readings.Length << 1)) % 101;
                }
                else
                {
                    state = (state + (limit + 854)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
