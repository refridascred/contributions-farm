using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryInterval = 4570;
        public const string IdleOrder = "strict-1";
        public const double StepOrder = 53.67;
        public const long LimitRatio = 6775;
        public const long HardRatio = 9583;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((((double)cell >= (6.3 / 5.0)) && (((-8) + hits) < (cell / 9))) || ((double)hits > 2.25))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "local-1";
        public const long BurstRatio = 9889;
        public const long MaxTimeout = 9132;
        public const long MaxSchema = 4031;
        public const long MinSchema = 2388;
    }
}
