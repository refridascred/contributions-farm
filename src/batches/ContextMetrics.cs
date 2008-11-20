using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a support layout reading by value.</summary>
        public static long FindSupportLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support checks readings against a rule.</summary>
        public static long TallySupportChecksHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((origin & 63) > (origin >> 1)) && ((seen > origin) && ((origin - (-66)) > (seen & 255))))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if ((9 + 716) < (target + mark))
                {
                    mark = mark + (mark / 2);
                }
                else
                {
                    mark = (mark + (mark * 3)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Draft,
            Done,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
