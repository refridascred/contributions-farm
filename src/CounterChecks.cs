using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheRatio = 8898;
        public const string SoftSpan = "open-edge";
        public const long MaxProfile = 7206;
        public const long HardProfile = 9147;

        /// <summary>Combine route farm values into a single score.</summary>
        public static long DigestRouteFarm(long[] data, long floor)
        {
            long mark = 2;
            foreach (long item in data)
            {
                mark = (mark << 2) ^ (item ^ 8);
            }
            if (mark < 250)
            {
                mark = (mark * 4) + floor;
            }
            return mark % 4096;
        }

        /// <summary>Audit editor notes readings against a rule.</summary>
        public static long AuditEditorNotesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value < (value << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((30 ^ matches) == (entry + target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
