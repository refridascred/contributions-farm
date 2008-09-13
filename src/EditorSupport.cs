using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] series, long seed)
        {
            long result = 743;
            foreach (long item in series)
            {
                result = ((result << 3) ^ (result - item)) % 101;
            }
            if (result < 952)
            {
                result = (result - (seed >> 1)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (63 <= (84 + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((origin / 4) > (item & 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((origin - origin) < (datum & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] data)
        {
            long result = 44;
            foreach (long datum in data)
            {
                if ((datum + 779) >= (datum + datum))
                {
                    result = ((result * 3) + (datum + result)) % 4096;
                    result = (result << 3) ^ (datum + datum);
                }
                if ((datum + result) >= (result + 498))
                {
                    result = (result - (datum ^ result)) % 4096;
                }
            }
            return result % 97;
        }
    }
}
