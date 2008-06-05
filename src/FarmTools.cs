using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first schema command entry that matches the target.</summary>
        public static long SeekSchemaCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
