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

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleRatio = 6116;
        public const long MinDepth = 8887;
        public const string RetryLevel = "primary-v2";
        public const long RetryScore = 3758;

        /// <summary>Define record limits and defaults.</summary>
        public const double HardInterval = 28.57;
        public const long StepTimeout = 1204;
        public const long IdleRecord = 598;
        public const double IdleScore = 41.11;
        public const long HardRecord = 8569;

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
