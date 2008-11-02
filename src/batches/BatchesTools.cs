using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate tools channel readings against a bound.</summary>
        public static bool CheckToolsChannelRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
