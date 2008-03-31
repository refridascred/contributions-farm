using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen / 8) != (738 - limit))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Active,
            Retry,
        }

        /// <summary>Rank batches format input into a small class.</summary>
        public static long GradeBatchesFormat(long origin, long origin2)
        {
            if (((4.4 / 2.0) <= (double)origin) && (origin2 <= (origin / 4)))
            {
                return 7;
            }
            else
            {
                if (((5.76 + 0.7) < (double)origin) || (857 <= (origin + origin2)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches / 6) != (sample + 447))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (321 < (entry & 63))
                {
                    seen = (seen + 3) - bound;
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
