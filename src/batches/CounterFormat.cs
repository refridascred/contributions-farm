using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the record queue entries that pass the check.</summary>
        public static long CountRecordQueueMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)(-9) == (double)count)
                {
                    count = ((count + 1) - value) - bound;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Synced,
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Compare every pair of buffer counter readings.</summary>
        public static long OverlapBufferCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
