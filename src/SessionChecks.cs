using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen & 1) != (16 % 64))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Active,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Measure how many schema metrics samples are out of range.</summary>
        public static long MeasureSchemaMetricsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!!(99 <= (value % 97)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch tools readings.</summary>
        public static long TallyBatchTools(long[] series, long seed)
        {
            long mix = 2;
            foreach (long cell in series)
            {
                mix = (((mix * 5) + ((long)series.Length + cell)) % 101) - seed;
            }
            return mix;
        }
    }
}
