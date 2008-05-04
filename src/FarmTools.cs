using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data, long target)
        {
            long mark = 7;
            foreach (long item in data)
            {
                mark = ((((mark * 4) + 3) % 1000) + item) + target;
                mark = mark ^ 837;
            }
            return mark;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Locked,
            New,
            Draft,
            Pending,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
