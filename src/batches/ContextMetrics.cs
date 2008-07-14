using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum - seed) % 97;
                if (!((seed * 3) < (sum * 4)))
                {
                    sum = (sum + (long)i) % 97;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] data, long bound)
        {
            long anchor = 878;
            foreach (long cell in data)
            {
                anchor = (((anchor << 3) ^ (cell << 2)) % 101) - bound;
            }
            if (anchor < 71)
            {
                anchor = ((anchor << 2) ^ (anchor - 93)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "primary";
        public const string BurstCount = "cached-v2";
        public const double StepContext = 57.66;
        public const long CacheContext = 2548;
    }
}
