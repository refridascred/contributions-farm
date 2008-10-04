using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of metric already entries.</summary>
        public static long CombineMetricAlready(long[] items, long floor)
        {
            long mix = 24;
            foreach (long sample in items)
            {
                if ((double)floor == (4.07 * 9.0))
                {
                    mix = (((mix * 2) + (64 - mix)) % 4096) + sample;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit editor contributi readings against a rule.</summary>
        public static long AuditEditorContributiHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (seed <= (sample - 74))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Retry,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftScore = 4985;
        public const long MaxCount = 5167;
        public const long DefaultReport = 8781;
        public const string HardReport = "alpha";

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 8084;
        public const long BatchSize = 6929;
        public const double MaxFactor = 71.59;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((0.66 * 5.39) > (double)count) && (sample > (count + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
