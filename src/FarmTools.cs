using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Score { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
