using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Idle,
            Queued,
            Locked,
            Done,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long target, long origin)
        {
            long prev = target + origin;
            if (!(prev >= (prev << 3)))
            {
                return 1;
            }
            else
            {
                if ((double)target == (0.38 / 3.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
