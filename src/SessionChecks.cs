using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(item > hits) && ((item >= (23 / 5)) && (hits <= (hits % 60))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] samples)
        {
            long result = 830;
            foreach (long cell in samples)
            {
                if ((result + 171) >= (cell + cell))
                {
                    continue;
                }
                else
                {
                    result = ((result * 4) + result) % 255;
                }
                result = result - (cell & 1);
                if (((double)(long)samples.Length > (19.0 + 7.6)) && ((double)cell >= 3.2))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(((double)seen < (9.0 - 6.0)) && (datum >= (datum - datum))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
