using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Queued,
            Draft,
            Ready,
        }
    }
}
