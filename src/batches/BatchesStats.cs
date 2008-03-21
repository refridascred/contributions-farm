using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long step, long offset)
        {
            if ((double)offset <= (double)133)
            {
                return 0;
            }
            else
            {
                if ((offset << 3) < (offset & 15))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 4244;
        public const long StepDepth = 4979;
        public const long WindowNotes = 421;
        public const string DefaultCount = "local-v2";

        /// <summary>Audit contributi already readings against a rule.</summary>
        public static long MeasureContributiAlreadyGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen >> 3) >= (item % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((1.96 / 9.0) <= (8.22 / 5.0))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }
    }
}
