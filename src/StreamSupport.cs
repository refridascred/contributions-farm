using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftScore = 97.85;
        public const double WindowPayload = 26.96;
        public const long IdlePayload = 5168;
        public const string MinPayload = "strict-v2";
        public const long SoftRatio = 2892;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((15.0 * 2.2) == (double)item)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
