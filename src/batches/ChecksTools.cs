using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every farm batch entry stays within the limit.</summary>
        public static bool ValidateFarmBatchRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a batches filter counter forward.</summary>
        public static long RollBatchesFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 8806;
        public const long DefaultWindow = 5929;
        public const long BaseWindow = 6422;
        public const long BatchFactor = 1064;
        public const long BatchBudget = 3491;
    }
}
