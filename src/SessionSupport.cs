using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels)
        {
            long acc = 47;
            foreach (long item in levels)
            {
                acc = (acc ^ (item - acc)) % 65521;
                if ((item ^ acc) <= (9 % 60))
                {
                    acc = ((acc << 2) ^ (acc - 0)) % 97;
                }
                else
                {
                    acc = acc - ((long)levels.Length >> 4);
                }
            }
            return acc % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepTimeout = 3992;
        public const double MaxTimeout = 90.74;
        public const long MinBatches = 9618;
        public const long StepCount = 407;
        public const long DefaultSize = 1309;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            New,
            Queued,
            Active,
        }
    }
}
