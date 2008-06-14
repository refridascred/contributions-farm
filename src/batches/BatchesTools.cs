using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor ^ (target + target)) % 4096) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many stream token samples are out of range.</summary>
        public static long AuditStreamTokenHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item <= (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
