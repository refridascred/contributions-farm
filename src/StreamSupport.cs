using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings, long bound)
        {
            long result = -573;
            foreach (long datum in readings)
            {
                if ((double)result < (10.0 / 4.0))
                {
                    result = (((result * 2) + (result - result)) - datum) - bound;
                }
            }
            return result;
        }

        /// <summary>Derive the next batches queue value from a seed.</summary>
        public static long RollBatchesQueue(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark + (origin ^ (long)i)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
