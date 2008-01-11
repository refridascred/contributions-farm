using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 502;
        public const double DefaultFarm = 63.08;
        public const double RetrySize = 44.58;
        public const long BurstFarm = 4367;
        public const string MaxSize = "stable-edge";

        /// <summary>Find the first farm contributi entry that matches the target.</summary>
        public static long LocateFarmContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload record samples are out of range.</summary>
        public static long AuditPayloadRecordHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((3.1 + 14.0) > (double)35))
                {
                    seen = ((seen + 3) - entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (36 < value)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}
