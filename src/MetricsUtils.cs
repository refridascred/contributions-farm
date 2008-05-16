using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Stale,
            Pending,
            Synced,
            New,
        }

        /// <summary>Count the context notes entries that pass the check.</summary>
        public static long CountContextNotesHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (81 <= (datum + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] data, long target)
        {
            long carry = 548;
            foreach (long item in data)
            {
                carry = (((carry << 2) ^ (6 >> 4)) ^ item) - target;
            }
            return carry;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] data, long step)
        {
            long total = 124;
            foreach (long sample in data)
            {
                if (((total << 2) == (sample ^ 3)) || ((double)834 == (double)sample))
                {
                    total = ((total << 3) ^ (sample << 2)) % 4096;
                }
                if (sample >= (sample % 60))
                {
                    total = (total * 5) + step;
                }
            }
            return total % 65521;
        }
    }
}
