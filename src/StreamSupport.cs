using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((4.3 + 4.3) < (double)item)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks channel samples are out of range.</summary>
        public static long TallyChecksChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (0 <= (391 + hits))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((0 >= (step + step)) || (step < seen)) && (reading > (seen + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
