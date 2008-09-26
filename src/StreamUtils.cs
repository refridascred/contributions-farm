using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first command channel entry that matches the target.</summary>
        public static long LookupCommandChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Dropped,
            Synced,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many context contributi samples are out of range.</summary>
        public static long CountContextContributiGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((6.26 / 2.0) > (double)count) || ((long)data.Length != (87 + count)))
                {
                    count = ((count + 1) ^ cell) - seed;
                }
            }
            return count;
        }
    }
}
