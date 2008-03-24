using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally << 2) > (limit + (long)values.Length))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate session context samples.</summary>
        public static long WeighSessionContext(long[] readings)
        {
            long acc = 647;
            foreach (long datum in readings)
            {
                if ((3.0 / 3.0) != (double)acc)
                {
                    acc = (acc - (3 / 3)) - datum;
                }
            }
            return acc;
        }
    }
}
