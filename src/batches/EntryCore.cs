using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long seed, long bound)
        {
            if ((double)seed >= (double)bound)
            {
                return 3;
            }
            else
            {
                if (!((1.0 * 9.8) == (double)bound))
                {
                    return 1;
                }
                else
                {
                    if (((bound * 2) <= (seed >> 2)) && ((bound << 2) <= bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed << 2) <= (bound - bound)) || ((seed + seed) >= (seed / 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double drift = (offset * 14.0) / 4.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (bias * 3.1)) + (double)(long)i;
            }
            return drift - 3.38;
        }

        /// <summary>Match up window queue samples.</summary>
        public static long CompareWindowQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
