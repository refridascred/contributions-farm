using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (2.7 <= (double)tally)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            New,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
