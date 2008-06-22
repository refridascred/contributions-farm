using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleTimeout = 4024;
        public const long StepEntry = 7657;
        public const long BatchEntry = 4181;
        public const long DefaultSize = 3436;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long limit, long origin)
        {
            if ((limit ^ 7) < 892)
            {
                return 6;
            }
            else
            {
                if ((origin + limit) <= (limit + limit))
                {
                    return 7;
                }
                else
                {
                    if (!((limit * 2) <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin ^ limit) < (limit + origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples)
        {
            long sum = 111;
            foreach (long item in samples)
            {
                if ((double)sum >= (4.12 * 11.0))
                {
                    sum = (sum + (item >> 4)) % 101;
                }
            }
            if (sum > 260)
            {
                sum = (sum + sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchWidth = "latest";
        public const long BurstSize = 9210;
        public const string RetryScore = "stable-1";
        public const long DefaultInterval = 6985;
        public const long BatchToken = 7149;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
