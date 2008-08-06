using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                result = (result - (datum / 7)) % 1000;
            }
            if (result < 266)
            {
                result = result - (result / 7);
            }
            return result;
        }
    }
}
