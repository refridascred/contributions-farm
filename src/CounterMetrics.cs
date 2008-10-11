using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit format record readings against a rule.</summary>
        public static long TallyFormatRecordHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((1 >> 2) <= (limit + matches))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample != (double)hits)
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double ratio, double floor)
        {
            double scale = ratio / 5.0;
            if (scale <= (floor - ratio))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + floor;
            }
            return scale + (9.0 - ratio);
        }
    }
}
