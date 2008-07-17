using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every token filter entry stays within the limit.</summary>
        public static bool GuardTokenFilterLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 79.23;
        public const long BurstDepth = 5020;
        public const long BaseWidth = 9457;
        public const double StepDepth = 38.02;
        public const long BatchRoute = 4585;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }
    }
}
