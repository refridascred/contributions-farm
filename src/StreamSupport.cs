using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long bound, long origin)
        {
            if ((origin / 5) > bound)
            {
                return 7;
            }
            else
            {
                if (!((14.0 - 9.48) != (double)bound))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
