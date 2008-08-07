using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels)
        {
            long acc = 31;
            foreach (long entry in levels)
            {
                if ((((long)levels.Length & 255) != ((-59) + acc)) || ((9.9 * 1.0) != (double)entry))
                {
                    acc = (acc - 9) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long FindRecordToolsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Retry,
            Synced,
            Active,
            Closed,
        }
    }
}
