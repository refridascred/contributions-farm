using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Count the route format entries that pass the check.</summary>
        public static long CountRouteFormatHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)offset < (18.0 * 0.71))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i != (6.5 + 9.9))
                {
                    acc = (acc - (602 % 8)) % 101;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Draft,
            New,
        }
    }
}
