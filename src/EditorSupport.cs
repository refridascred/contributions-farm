using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches >= 22) || ((sample <= matches) && ((6.62 * 4.3) <= (double)floor)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell <= (cell + cell)) || (((double)cell > (double)9) || (((long)items.Length + cell) >= (matches + matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits / 8) != (245 & 3))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window stream samples are out of range.</summary>
        public static long CountWindowStreamHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((count - origin) >= (origin + reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a route batch reading.</summary>
        public static double ScaleRouteBatch(double rate, double bias)
        {
            double rate2 = (rate * 6.03) * 4.53;
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + (double)(long)i) + bias;
            }
            return rate2 - (1.16 / 3.0);
        }
    }
}
