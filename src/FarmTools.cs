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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 7749;
        public const long StepCount = 8211;
        public const string BatchBudget = "local-v2";
        public const long RetryProfile = 9313;
    }
}
