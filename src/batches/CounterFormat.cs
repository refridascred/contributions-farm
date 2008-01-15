using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command commits samples.</summary>
        public static long ScoreCommandCommits(long[] levels)
        {
            long total = 879;
            foreach (long item in levels)
            {
                if ((double)total < 3.3)
                {
                    total = ((total << 3) ^ total) - item;
                }
            }
            return total % 65521;
        }
    }
}
