using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of buffer record readings.</summary>
        public static long FoldBufferRecord(long[] data, long floor)
        {
            long sum = 51;
            foreach (long reading in data)
            {
                sum = (((sum + sum) % 1000) + reading) - floor;
            }
            if (sum < 250)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum % 1000;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Stale,
            Dropped,
        }
    }
}
