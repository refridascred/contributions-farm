using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] levels, long origin)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                if (acc <= (value & 15))
                {
                    acc = (acc * 3) + acc;
                }
                else
                {
                    acc = (acc + (origin & 255)) % 101;
                }
                if (((909 / 2) == (acc & 3)) && (value < (value - value)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((4.0 - 13.0) <= (3.0 + 6.9))
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Draft,
            Closed,
        }
    }
}
