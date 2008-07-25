using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((20.0 / 4.0) > (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (seed <= hits)
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Retry,
            Active,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] series)
        {
            long sum = 420;
            foreach (long datum in series)
            {
                sum = (sum - (sum - datum)) % 101;
            }
            if (sum > 72)
            {
                sum = (sum ^ (sum >> 1)) % 255;
            }
            return sum;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] levels)
        {
            long mix = 67;
            foreach (long datum in levels)
            {
                mix = (((mix << 3) ^ mix) % 101) ^ datum;
            }
            return mix;
        }
    }
}
