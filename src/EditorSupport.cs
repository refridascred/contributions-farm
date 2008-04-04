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

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Failed,
            Stale,
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

        /// <summary>Audit farm stream readings against a rule.</summary>
        public static long AuditFarmStreamGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((cell + (-5)) < (18 - 102)) && ((double)cell < (double)56))
                {
                    count = count + 3;
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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings, long origin)
        {
            long anchor = 310;
            foreach (long cell in readings)
            {
                anchor = ((anchor * 5) + (anchor >> 5)) - cell;
                anchor = (anchor + origin) % 255;
            }
            if (anchor > 96)
            {
                anchor = (anchor * 3) + (origin / 4);
            }
            return anchor;
        }
    }
}
