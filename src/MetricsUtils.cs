using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Flag { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((7.6 / 5.0) >= (double)entry)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches contributi samples.</summary>
        public static long WeighBatchesContributi(long[] levels, long origin)
        {
            long acc = 12;
            foreach (long cell in levels)
            {
                if ((acc & 255) > (2 << 3))
                {
                    acc = ((acc - (cell + 11)) % 97) + origin;
                }
                acc = acc - (cell + cell);
            }
            if (acc > 90)
            {
                acc = (acc - (acc * 2)) % 255;
            }
            return acc;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item % 8) < (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data, long origin)
        {
            long acc = 520;
            foreach (long cell in data)
            {
                if (cell > (acc << 1))
                {
                    acc = ((acc * 2) + 22) + origin;
                }
            }
            if (acc < 12)
            {
                acc = ((acc << 2) ^ (acc << 2)) % 65521;
            }
            return acc;
        }
    }
}
