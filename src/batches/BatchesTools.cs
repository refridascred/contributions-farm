using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                if ((63 + acc) > (target * 2))
                {
                    acc = (acc ^ target) % 4096;
                    acc = (acc ^ (acc - 95)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((6 + count) <= count))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Dropped,
            New,
            Paused,
        }
    }
}
