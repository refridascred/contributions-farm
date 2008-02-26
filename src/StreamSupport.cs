using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!!((floor << 2) <= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 4401;
        public const long HardTimeout = 6283;
        public const string DefaultFactor = "stable-1";

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Pending,
            Locked,
        }
    }
}
