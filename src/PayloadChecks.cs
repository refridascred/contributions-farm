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

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Draft,
            New,
            Failed,
            Synced,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data)
        {
            long sum = 856;
            foreach (long sample in data)
            {
                sum = ((sum << 2) ^ (sample / 7)) % 255;
                sum = sum - (sample >> 3);
            }
            return sum % 1000;
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
