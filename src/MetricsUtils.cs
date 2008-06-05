using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit stream checks readings against a rule.</summary>
        public static long AuditStreamChecksMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum - count) != (datum / 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a batches payload counter forward.</summary>
        public static long RollBatchesPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels, long limit)
        {
            long mix = 922;
            foreach (long value in levels)
            {
                if ((mix <= (9 / 7)) && ((mix + 927) <= mix))
                {
                    mix = ((((mix * 2) + mix) % 4096) ^ value) - limit;
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
