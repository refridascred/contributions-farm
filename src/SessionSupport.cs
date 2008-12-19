using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many token command samples are out of range.</summary>
        public static long TallyTokenCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits == (5.7 / 3.0))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 25.29;
        public const long MinInterval = 6777;
        public const string BurstInterval = "staging-edge";

        /// <summary>Define session limits and defaults.</summary>
        public const double StepDepth = 31.64;
        public const string IdleCount = "strict-v2";
        public const long LimitSession = 9612;
        public const long BatchSession = 6543;
        public const double IdleWidth = 32.99;
    }
}
