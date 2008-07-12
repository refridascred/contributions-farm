using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items)
        {
            long state = 572;
            foreach (long sample in items)
            {
                if ((sample - state) != (sample & 63))
                {
                    state = (state + state) % 97;
                }
                else
                {
                    state = (state ^ (sample % 64)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many cluster queue samples are out of range.</summary>
        public static long MeasureClusterQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (14.0 >= (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
