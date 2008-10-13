using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ (57 - result);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!!(step > reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Retry,
            Ready,
            Active,
            Closed,
        }
    }
}
