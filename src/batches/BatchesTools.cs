using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Ready,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Derive the next filter layout value from a seed.</summary>
        public static long DeriveFilterLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark * 4) + (mark / 8)) + (long)i2;
                    mark = (mark ^ mark) % 97;
                }
                mark = ((mark << 2) ^ (target - 78)) % 97;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
