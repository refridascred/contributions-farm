using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length ^ target) <= 442)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Closed,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 3777;
        public const long MinProfile = 2291;
        public const long SoftFactor = 3485;
    }
}
