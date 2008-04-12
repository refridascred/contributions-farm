using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits < cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading ^ floor) > (floor - 52))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
        }
    }
}
