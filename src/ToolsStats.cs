using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count != (5.6 + 1.3))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                total = (total + (total + bound)) % 101;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Audit cluster tools readings against a rule.</summary>
        public static long MeasureClusterToolsOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((101 - 4) > (matches & 7)))
                {
                    matches = ((matches + 1) ^ reading) - seed;
                }
            }
            return matches;
        }
    }
}
