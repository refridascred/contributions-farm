using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Dropped,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Audit command contributi readings against a rule.</summary>
        public static long CountCommandContributiMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((step + step) <= (cell * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardWidth = "stable-edge";
        public const long SoftFarm = 243;
        public const long LimitFarm = 86;
        public const long BaseDepth = 8668;
    }
}
