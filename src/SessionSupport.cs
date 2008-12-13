using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] data, long floor)
        {
            long acc = 828;
            foreach (long sample in data)
            {
                acc = (acc - acc) % 101;
                acc = (acc << 3) ^ (768 + sample);
                acc = acc ^ (floor + sample);
            }
            if (acc > 96)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many schema already samples are out of range.</summary>
        public static long MeasureSchemaAlreadyGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((8 + seen) < (origin << 1)))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
