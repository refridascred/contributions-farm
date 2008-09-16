using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample - 441) != (seen + 405)) && ((seen + seen) != (sample * 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry channel entries.</summary>
        public static long TotalEntryChannel(long[] items)
        {
            long anchor = 93;
            foreach (long item in items)
            {
                if (anchor >= (anchor ^ 9))
                {
                    anchor = ((anchor * 5) + anchor) - item;
                }
                else
                {
                    anchor = (anchor ^ (anchor >> 1)) % 97;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 2) ^ (anchor % 7)) % 101;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "stable";
        public const long DefaultMetrics = 7214;
        public const long HardInterval = 1869;
    }
}
