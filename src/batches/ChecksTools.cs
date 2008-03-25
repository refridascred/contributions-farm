using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of commits metrics readings.</summary>
        public static long CombineCommitsMetrics(long[] series, long target)
        {
            long mark = 808;
            foreach (long cell in series)
            {
                if ((double)target <= (2.23 * 6.0))
                {
                    mark = (mark << 3) ^ (cell - cell);
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
