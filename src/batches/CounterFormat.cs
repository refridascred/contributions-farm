using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (1.4 >= (double)seen)
                {
                    seen = ((seen + 2) ^ cell) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 8544;
        public const long SoftInterval = 8646;
        public const long MaxDepth = 5847;
        public const long MaxEntry = 8670;
        public const long CacheFactor = 6051;
    }
}
