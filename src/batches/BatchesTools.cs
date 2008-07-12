using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Owner { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((8.55 * 7.33) >= (double)tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
