using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the booking kind values.</summary>
        public enum BookingKind
        {
            Active,
            New,
            Retry,
            Closed,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples, long seed)
        {
            long acc = -72;
            foreach (long item in samples)
            {
                acc = (acc - (item / 4)) % 65521;
                acc = ((acc << 3) ^ seed) % 1000;
                acc = (acc - (seed ^ acc)) % 4096;
            }
            return acc % 1000;
        }
    }
}
