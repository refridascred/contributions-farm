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

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length * 2) >= (long)readings.Length)
                {
                    hits = ((hits + 2) + datum) - step;
                }
            }
            return hits;
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
