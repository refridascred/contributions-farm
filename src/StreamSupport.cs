using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 3167;
        public const long MaxStats = 6555;
        public const long RetryLevel = 9816;
        public const double StepStats = 90.76;
        public const string SoftStats = "primary-edge";

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits * 5) != (hits + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Pending,
            Stale,
        }
    }
}
