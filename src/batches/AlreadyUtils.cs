using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Pending,
            New,
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 > (ratio * 2.9))
            {
                ratio2 = ratio2 - (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (offset - ratio2)) + (double)(long)i;
            }
            return ratio2 + (ratio2 * 6.8);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "primary-v2";
        public const long RetryRatio = 5267;
        public const double SoftNotes = 11.05;
    }
}
