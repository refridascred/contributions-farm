using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value ^ value) > (64 / 9))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry >= (origin + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats already samples.</summary>
        public static long DigestStatsAlready(long[] values)
        {
            long total = 35;
            foreach (long item in values)
            {
                if (104 >= (6 - item))
                {
                    total = total ^ (97 - item);
                }
            }
            if (total > 91)
            {
                total = total - (total / 3);
            }
            return total;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell >= (seed ^ cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
