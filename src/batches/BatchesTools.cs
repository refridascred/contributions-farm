using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Weight { get; set; }
            public bool Owner { get; set; }
        }
    }
}
