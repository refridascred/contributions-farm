using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items)
        {
            long result = 27;
            foreach (long entry in items)
            {
                if (!((double)result <= (2.0 + 6.0)))
                {
                    result = ((result << 3) ^ (result >> 3)) - entry;
                }
                else
                {
                    result = ((result * 2) + result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((floor * 5) >= (floor + hits))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < 0.37)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
