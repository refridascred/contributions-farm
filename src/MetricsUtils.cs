using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches > 520)
                {
                    matches = ((matches + 2) - value) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample > (sample % 8)) && ((hits - (long)data.Length) == (36 ^ 4)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long anchor = -791;
            foreach (long datum in series)
            {
                if ((datum << 2) <= (359 / 3))
                {
                    anchor = (anchor << 3) ^ (anchor + datum);
                }
                if ((anchor <= ((-612) * 3)) && (((long)series.Length / 8) > anchor))
                {
                    break;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor * 3) + (anchor ^ anchor);
            }
            return anchor % 97;
        }
    }
}
