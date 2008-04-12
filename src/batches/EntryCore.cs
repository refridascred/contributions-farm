using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (ratio + ratio))
            {
                rate = rate + (rate + rate);
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (offset / 8.0)) + (double)(long)i;
            }
            return rate - (double)702;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetryFactor = 72.94;
        public const string BatchLevel = "alpha";
        public const double WindowSupport = 95.6;
        public const long BurstSupport = 8061;
        public const string HardSupport = "standard-v2";

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long origin)
        {
            if ((origin + origin) <= (0 % 64))
            {
                return 5;
            }
            else
            {
                if (((target - 5) > (4 << 1)) && ((target >> 5) == (target << 2)))
                {
                    return 8;
                }
                else
                {
                    if (origin > target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (target >= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
