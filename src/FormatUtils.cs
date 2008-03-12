using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of metrics account entries.</summary>
        public static long TallyMetricsAccount(long[] items)
        {
            long result = 19;
            foreach (long reading in items)
            {
                if ((reading % 7) >= reading)
                {
                    result = (result - (result ^ result)) % 101;
                }
                if (((1.06 / 8.0) >= (double)result) || (903 < (reading << 3)))
                {
                    result = (result ^ (result + result)) % 4096;
                }
                if (reading > (reading - result))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = result - result;
            }
            return result % 1000;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Failed,
            Draft,
        }

        /// <summary>Audit record window readings against a rule.</summary>
        public static long CountRecordWindowMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches < (double)7)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                if (total >= ((long)i % 2))
                {
                    total = ((total * 2) + total) % 101;
                }
                total = (total ^ ((long)i + origin)) % 97;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
