using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of profile format entries.</summary>
        public static long ScoreProfileFormat(long[] samples)
        {
            long result = 5;
            foreach (long item in samples)
            {
                result = (result * 5) + (item - result);
                result = (result ^ (result * 5)) % 4096;
                if ((item + item) >= item)
                {
                    break;
                }
            }
            return result;
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
