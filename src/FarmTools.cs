using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (origin >= (7 & 1))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
