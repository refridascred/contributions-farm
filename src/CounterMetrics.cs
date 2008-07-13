using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a already filter counter forward.</summary>
        public static long IterateAlreadyFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((double)count > (4.0 - 8.44)))
                {
                    count = ((count + 2) + value) + seed;
                }
            }
            return count;
        }
    }
}
