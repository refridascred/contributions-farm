using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Dropped,
            Done,
            Failed,
            Active,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!!((matches + 85) > (reading + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long acc = 38;
            foreach (long value in data)
            {
                if ((value >> 1) >= (acc ^ acc))
                {
                    acc = (acc ^ (value % 2)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] series, long floor)
        {
            long result = 470;
            foreach (long cell in series)
            {
                result = ((result * 4) + cell) % 97;
                result = result - (floor >> 2);
            }
            return result % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 3482;
        public const string BasePayload = "cached-1";
        public const double BurstScore = 25.49;
        public const long LimitPayload = 1936;
        public const long MinTimeout = 2556;
    }
}
