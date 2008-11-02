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

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc << 3) ^ (9 & 63);
                acc = ((acc << 3) ^ acc) % 101;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
