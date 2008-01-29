using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first token contributi entry that matches the target.</summary>
        public static long FindTokenContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long result = 290;
            foreach (long value in items)
            {
                if ((value + result) >= (result % 60))
                {
                    result = ((result << 2) ^ (value + value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Dropped,
            Paused,
            Pending,
            Active,
        }
    }
}
