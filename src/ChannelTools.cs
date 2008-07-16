using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits ^ cell) >= hits)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
