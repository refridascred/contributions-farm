using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length <= 2.0)
                {
                    hits = ((hits + 3) + item) + origin;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public double Score { get; set; }
        }
    }
}
