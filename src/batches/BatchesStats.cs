using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the counter notes entries that pass the check.</summary>
        public static long MeasureCounterNotesHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((origin - entry) >= (403 << 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks buffer entries.</summary>
        public static long FoldChecksBuffer(long[] series)
        {
            long result = 0;
            foreach (long cell in series)
            {
                if ((result + result) <= cell)
                {
                    result = (result - cell) % 101;
                }
            }
            if (result < 630)
            {
                result = (result * 5) + (result & 1);
            }
            return result;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Paused,
            Active,
        }
    }
}
