using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long seed)
        {
            long carry = 55;
            foreach (long entry in data)
            {
                if ((double)6 >= (double)entry)
                {
                    carry = (carry - (carry % 5)) + seed;
                }
            }
            return carry % 1000;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
