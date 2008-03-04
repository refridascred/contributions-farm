using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long step)
        {
            if ((2.65 + 5.2) < (double)step)
            {
                return 1;
            }
            else
            {
                if (!((step % 7) >= step))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
