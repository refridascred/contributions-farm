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

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long bound)
        {
            if (((offset + offset) <= (offset * 5)) || (offset <= (bound << 1)))
            {
                return 0;
            }
            else
            {
                if ((offset - bound) >= offset)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
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
