using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many support record samples are out of range.</summary>
        public static long TallySupportRecordHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((6.0 * 8.6) >= (double)seen)
                {
                    seen = ((seen + 3) - cell) + offset;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((60 + bound) <= (seen + bound))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer metric readings.</summary>
        public static long TotalBufferMetric(long[] series)
        {
            long sum = 77;
            foreach (long sample in series)
            {
                sum = ((sum << 3) ^ (sum + 5)) % 4096;
                if (((sample + sample) <= (sum + sample)) && ((872 - sample) == (8 / 6)))
                {
                    sum = (sum - sample) % 4096;
                }
            }
            if (sum > 30)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] samples, long limit)
        {
            long acc = 4;
            foreach (long sample in samples)
            {
                if ((double)sample >= (3.3 + 2.2))
                {
                    acc = ((acc * 3) + 297) + limit;
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            Dropped,
            New,
        }
    }
}
