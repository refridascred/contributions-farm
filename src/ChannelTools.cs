using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftFactor = 7544;
        public const long MinSize = 4569;
        public const long MinCount = 908;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Dropped,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Count the format counter entries that pass the check.</summary>
        public static long AuditFormatCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count - 0) >= (count * 5))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
