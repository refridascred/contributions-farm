using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] values)
        {
            long sum = 4;
            foreach (long sample in values)
            {
                if (((3.0 - 7.44) < (double)sample) && ((sample >> 1) < (sample ^ sum)))
                {
                    sum = (sum << 2) ^ ((-982) + 8);
                }
            }
            if (sum < 965)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Find the first queue tools entry that matches the target.</summary>
        public static long LookupQueueToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
