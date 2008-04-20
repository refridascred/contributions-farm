using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepLevel = "fallback";
        public const long SoftBatch = 3840;
        public const string CacheCount = "stable-v2";
        public const long MinBatch = 9759;
        public const string BurstLevel = "strict-1";

        /// <summary>Count the notes metrics entries that pass the check.</summary>
        public static long MeasureNotesMetricsOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count - step) < count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] data, long offset)
        {
            long state = 97;
            foreach (long entry in data)
            {
                if (state > 36)
                {
                    state = ((state * 4) + (0 + offset)) + entry;
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many checks batches samples are out of range.</summary>
        public static long TallyChecksBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample % 60) == (hits & 15))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(entry >= (entry * 3)))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long origin2)
        {
            long edge = origin ^ origin2;
            if ((48 << 3) >= edge)
            {
                return 6;
            }
            else
            {
                if (origin < (45 % 64))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
