using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long origin, long bound)
        {
            long next = origin - bound;
            if (((789 ^ origin) <= next) && (origin <= (bound + 663)))
            {
                return 3;
            }
            else
            {
                if ((origin <= (origin % 60)) || (8 <= (next + origin)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit schema checks readings against a rule.</summary>
        public static long MeasureSchemaChecksMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((8.61 / 8.0) == (double)matches)
                {
                    matches = ((matches + 1) ^ entry) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
