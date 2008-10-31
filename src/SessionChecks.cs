using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema notes samples are out of range.</summary>
        public static long CountSchemaNotesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((1.1 / 9.0) > (double)seen)
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample - hits) > sample) && ((hits % 12) > (sample + sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 5769;
        public const long HardRatio = 1120;
        public const string HardToken = "primary";
    }
}
