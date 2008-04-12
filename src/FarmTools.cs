using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (acc + acc)) % 4096;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
