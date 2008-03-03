using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a entry layout reading by value.</summary>
        public static long SeekEntryLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (44 <= (cell - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up batch record samples.</summary>
        public static long CompareBatchRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
