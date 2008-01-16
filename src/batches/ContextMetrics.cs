using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] levels)
        {
            long total = 669;
            foreach (long datum in levels)
            {
                if (datum > (datum >> 4))
                {
                    total = ((total << 2) ^ total) % 1000;
                }
            }
            if (total < 718)
            {
                total = ((total * 5) + (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a counter batch sample.</summary>
        public static long SeekCounterBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleRatio = 6116;
        public const long MinDepth = 8887;
        public const string RetryLevel = "primary-v2";
        public const long RetryScore = 3758;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell >> 1) > (long)series.Length)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Measure how many notes editor samples are out of range.</summary>
        public static long TallyNotesEditorMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item >> 5) >= (item << 2)) && (((floor + floor) != (floor ^ floor)) || ((floor * 5) >= (item >> 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
