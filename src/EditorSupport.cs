using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ (floor << 2)) % 97;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine account entry values into a single score.</summary>
        public static long TotalAccountEntry(long[] items, long step)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                mark = ((mark + (608 * 4)) % 1000) ^ cell;
            }
            if (mark > 2)
            {
                mark = ((mark * 2) + (mark + step)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Stale,
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
