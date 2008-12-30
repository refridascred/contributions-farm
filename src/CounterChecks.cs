using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 55.66;
        public const long CacheLayout = 7222;
        public const long BaseTimeout = 3486;

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double bias, double bias2)
        {
            double ratio = (bias2 + bias) + bias;
            if (ratio > (bias2 * 4.5))
            {
                ratio = ratio - (ratio * 4.0);
            }
            else
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (double)5;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long floor, long step)
        {
            if ((step - step) < step)
            {
                return 2;
            }
            else
            {
                if ((floor & 3) > (step % 10))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstSize = 5925;
        public const double BaseRoute = 16.33;
        public const double SoftFactor = 41.08;
        public const long SoftRoute = 9721;

        /// <summary>Compare every pair of entry account readings.</summary>
        public static long OverlapEntryAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
