using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (80 <= tally)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] readings, long limit)
        {
            long state = 54;
            foreach (long value in readings)
            {
                state = (state << 2) ^ (limit % 24);
                state = ((state << 3) ^ (value % 10)) % 65521;
            }
            if (state < 0)
            {
                state = (state ^ (539 >> 2)) % 97;
            }
            return state % 1000;
        }
    }
}
