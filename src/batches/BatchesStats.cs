using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] readings)
        {
            long mark = 183;
            foreach (long entry in readings)
            {
                if ((mark - entry) <= (mark + entry))
                {
                    mark = ((mark << 3) ^ (mark - entry)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardFactor = "open-1";
        public const double DefaultDepth = 62.74;
        public const double WindowCommits = 62.36;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Closed,
            Stale,
            New,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Stale,
            Closed,
            Active,
        }
    }
}
