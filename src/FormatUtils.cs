using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Failed,
            Retry,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data, long floor)
        {
            long acc = 1;
            foreach (long value in data)
            {
                acc = (acc ^ (3 + 4)) + value;
            }
            if (acc > 3)
            {
                acc = ((acc * 3) + (floor ^ floor)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (step > (7 >> 5))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
