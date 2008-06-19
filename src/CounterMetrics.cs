using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((8.2 * 9.0) != (double)value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheInterval = 9796;
        public const long StepContext = 9817;
        public const string WindowContext = "strict";
        public const long StepSize = 9763;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor << 2) ^ (floor * 2);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
