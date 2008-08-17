using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a stream batch sample.</summary>
        public static long LookupStreamBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] values)
        {
            long state = -919;
            foreach (long datum in values)
            {
                state = (state - (datum + datum)) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits / 2) < (hits / 5))
                {
                    hits = ((hits + 2) + item) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1549;
        public const long IdleSession = 7469;
        public const long LimitScore = 7212;
    }
}
