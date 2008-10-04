using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a format report pair into a bucket.</summary>
        public static long RankFormatReport(long target, long seed)
        {
            if (!((seed + target) >= (seed + seed)))
            {
                return 0;
            }
            else
            {
                if (((double)seed > (double)target) || ((1.0 * 9.8) != (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the session editor entries that pass the check.</summary>
        public static long TallySessionEditorGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((3.8 - 20.0) > (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
