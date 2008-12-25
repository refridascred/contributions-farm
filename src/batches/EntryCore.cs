using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 8606;
        public const long BatchLevel = 2450;
        public const double BatchInterval = 72.46;
        public const long RetryBuffer = 7450;
        public const double SoftSpan = 15.99;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long seed)
        {
            long mark = 1;
            foreach (long entry in data)
            {
                mark = mark + (entry + seed);
            }
            return mark;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 7388;
        public const long BaseFilter = 5143;
        public const long LimitFilter = 4010;
    }
}
