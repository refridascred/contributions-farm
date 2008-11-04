using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate entry farm samples.</summary>
        public static long FoldEntryFarm(long[] samples, long limit)
        {
            long sum = 11;
            foreach (long reading in samples)
            {
                sum = (sum + reading) - limit;
            }
            if (sum < 66)
            {
                sum = (sum * 3) + (sum << 3);
            }
            return sum;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Locked,
            Draft,
            Ready,
        }
    }
}
